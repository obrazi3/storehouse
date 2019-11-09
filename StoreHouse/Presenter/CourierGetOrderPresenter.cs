using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    class CourierGetOrderPresenter : IPresenter
    {
        IKernel _kernel;
        ICourierGetOrderView _view;

        public CourierGetOrderPresenter(IKernel kernel, ICourierGetOrderView view)
        {
            _kernel = kernel;
            _view = view;

            _view.ConfirmDelivery += () => ConfirmDelivery();
            _view.Back += () => CancelOrder();
            _view.InspectOrder += () => ConfirmDelivery();

        }

        private void CancelOrder()
        {
            _kernel.Get<CourierPresenter>().Run();
            _view.Close();
        }

        private void InspectOrder()
        {

        }
        private void ConfirmDelivery()
        {

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
