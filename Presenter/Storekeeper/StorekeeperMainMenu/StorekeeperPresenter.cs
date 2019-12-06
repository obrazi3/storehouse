using Ninject;

namespace Presenter
{
    public class StorekeeperPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IStorekeeperView _view;

        public StorekeeperPresenter(IKernel kernel, IStorekeeperView view)
        {
            _kernel = kernel;
            _view = view;

            _view.SearchProviderOrder += OnButtonProviderOrderClick;
            _view.Back += OnButtonBackClick;
            _view.SearchClientOrder += OnButtonSearchClientOrderClick;
        }


        public void Run()
        {
            _view.Show();
        }

        private void OnButtonSearchClientOrderClick()
        {
            _kernel.Get<StorekeeperSearchClientOrderPresenter>().Run();
            _view.Close();
        }

        private void OnButtonProviderOrderClick()
        {
            _kernel.Get<StorekeeperSearchProviderOrderPresenter>().Run();
            _view.Close();
        }

        private void OnButtonBackClick()
        {
            _kernel.Get<SignInPresenter>().Run();
            _view.Close();
        }
    }
}
