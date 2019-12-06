using Model;
using Ninject;

namespace Presenter
{
    public class StorekeeperSearchClientOrderPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IStorekeeperSearchClientOrderView view;
        private IClientOrderServiceForStorekeeper model;
        private int orderNumber;

        public StorekeeperSearchClientOrderPresenter(IKernel _kernel, IStorekeeperSearchClientOrderView _view,
            IClientOrderServiceForStorekeeper _model)
        {
            kernel = _kernel;
            view = _view;
            model = _model;

            view.Back += OnButtonBackClick;
            view.Search += OnButtonSearchClick;
            view.ConfirmGiveOut += OnButtonConfirmOrderClick;

            orderNumber = -1;
        }

        public void Run()
        {
            view.Show();
        }

        public void OnButtonBackClick()
        {
            kernel.Get<StorekeeperPresenter>().Run();
            view.Close();
        }

        public void OnButtonSearchClick()
        {
            var order = model.GetGiveOutClientOrder(view.GetOrderNumber());
            view.SetOrderInfo(order);
            if (order != null)
                orderNumber = order.OrderId;
        }

        public void OnButtonConfirmOrderClick()
        {
            if (orderNumber != -1)
            {
                model.ConfirmGiveOutClientOrder(orderNumber);
                orderNumber = -1;
                view.ClearView();
            }
        }
    }
}
