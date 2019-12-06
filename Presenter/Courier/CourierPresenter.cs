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

            _view.GetInfoOrder += GetOrder;
            _view.Back += Back;
        }

        public void Run()
        {
            _view.Show();
        }


        private void GetOrder()
        {
            _kernel.Get<CourierGetOrderPresenter>().Run();
            _view.Close();
        }

        private void Back()
        {
            _kernel.Get<SignInPresenter>().Run();
            _view.Close();
        }
    }
}
