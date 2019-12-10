using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerInspectOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerInspectOrderView _view;
        private readonly IClientOrderServiceForClientManager _model;
        private ClientOrder _order;

        public ClientManagerInspectOrderPresenter(IKernel kernel, IClientManagerInspectOrderView view,
            IClientOrderServiceForClientManager model)
        {
            _kernel = kernel;
            _view = view;
            _model = model;

            _view.Back += () => Back();
            _view.RemoveOrder += () => RemoveOrder();
            _view.EditOrder += () => EditOrder();
            _view.SearchOrder += () => SearchOrder();
        }

        public ClientManagerInspectOrderPresenter(IKernel kernel, IClientManagerInspectOrderView view,
            IClientOrderServiceForClientManager model, ClientOrder order) : this(kernel, view, model)
        {
            _order = _model.GetNotPaidOrder(order.OrderId);
            _view.SetOrderInfo((ClientOrder)_order.Clone());
        }


        private void Back()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

        private void RemoveOrder()
        {
            if (_order != null)
            {
                _model.RemoveNotPaidOrder(_order.OrderId);
                _view.ClearView();
            }
        }

        private void EditOrder()
        {
            if (_order != null)
            {
                new ClientManagerEditOrderFirstStepPresenter(_kernel,
                    _kernel.Get<IClientManagerAddOrderFirstStepView>(), _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                    _order).Run();
                _view.Close();
            }
        }

        private void SearchOrder()
        {
            _order = _model.GetNotPaidOrder(_view.GetOrderNumber());
            if (_order != null)
                _view.SetOrderInfo((ClientOrder)_order.Clone());
            else
                _view.SetOrderInfo(_order);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
