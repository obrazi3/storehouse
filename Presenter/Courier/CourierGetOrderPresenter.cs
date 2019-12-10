using Model;
using Ninject;

namespace Presenter
{
    public class CourierGetOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private ICourierGetOrderView _view;
        private IClientOrderServiceForCourier _model;
        private int _orderId;

        public CourierGetOrderPresenter(IKernel kernel, ICourierGetOrderView view,
            IClientOrderServiceForCourier model)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;

            this._view.ConfirmDelivery += ConfirmDelivery;
            this._view.Back += CancelOrder;
            var order = this._model.GetForDeliveryClientOrder();
            if (order != null)
                _orderId = order.OrderId;
            else
                _orderId = -1;
            this._view.SetOrderInfo(order);
        }

        public void Run()
        {
            if (_orderId != -1)
                _view.Show();
            else
                CancelOrder();
        }

        private void CancelOrder()
        {
            if (_orderId != -1)
                _model.CancelDelivery(_orderId);
            _kernel.Get<CourierPresenter>().Run();
            _view.Close();
        }

        private void ConfirmDelivery()
        {
            if (_orderId != -1)
            {
                _model.ConfirmDelivery(_orderId);
                _view.ShowMessageSuccessConfirm();
                _kernel.Get<CourierPresenter>().Run();
                _view.Close();
            }
        }
    }
}
