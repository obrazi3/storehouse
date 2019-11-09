using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presenter
{
   public class CourierPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICourierView _view;

       public CourierPresenter(IKernel kernel, ICourierView view)
        {
            _kernel = kernel;
            _view = view;

            _view.GetInfoOrder += () => GetOrder();
        }

        private void GetOrder()
        {
            _kernel.Get<CourierGetOrderPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
