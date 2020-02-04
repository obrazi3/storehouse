using Model;
using Ninject;

namespace Presenter
{
    public class StorekeeperSearchClientOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IStorekeeperSearchClientOrderView _view;
        private IClientOrderServiceForStorekeeper _model;
        private int _orderNumber;

        public StorekeeperSearchClientOrderPresenter(IKernel kernel, IStorekeeperSearchClientOrderView view,
            IClientOrderServiceForStorekeeper model)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;

            this._view.Back += OnButtonBackClick;
            this._view.Search += OnButtonSearchClick;
            this._view.ConfirmGiveOut += OnButtonConfirmOrderClick;

            _orderNumber = -1;
        }

        public void Run()
        {
            _view.Show();
        }

        public void OnButtonBackClick()
        {
            _kernel.Get<StorekeeperPresenter>().Run();
            _view.Close();
        }

        public void OnButtonSearchClick()
        {
            var order = _model.GetGiveOutClientOrder(_view.GetOrderNumber());
            _view.SetOrderInfo(order);
            if (order != null)
                _orderNumber = order.OrderId;
        }

        public void OnButtonConfirmOrderClick()
        {
            if (_orderNumber != -1)
            {
                _model.ConfirmGiveOutClientOrder(_orderNumber);
                _orderNumber = -1;
                _view.ClearView();
            }
        }
    }
}
