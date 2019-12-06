using Model;
using Ninject;

namespace Presenter
{
    public class CourierGetOrderPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private ICourierGetOrderView view;
        private IClientOrderServiceForCourier model;
        private int orderId;

        public CourierGetOrderPresenter(IKernel _kernel, ICourierGetOrderView _view,
            IClientOrderServiceForCourier _model)
        {
            this.kernel = _kernel;
            this.view = _view;
            this.model = _model;

            this.view.ConfirmDelivery += ConfirmDelivery;
            this.view.Back += CancelOrder;
            var order = model.GetForDeliveryClientOrder();
            if (order != null)
                orderId = order.OrderId;
            else
                orderId = -1;
            this.view.SetOrderInfo(order);
        }

        public void Run()
        {
            if (orderId != -1)
                view.Show();
            else
                CancelOrder();
        }

        private void CancelOrder()
        {
            if (orderId != -1)
                model.CancelDelivery(orderId);
            kernel.Get<CourierPresenter>().Run();
            view.Close();
        }

        private void ConfirmDelivery()
        {
            if (orderId != -1)
            {
                model.ConfirmDelivery(orderId);
                view.ShowMessageSuccessConfirm();
                kernel.Get<CourierPresenter>().Run();
                view.Close();
            }
        }
    }
}
