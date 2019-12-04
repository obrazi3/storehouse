using Ninject;

namespace Presenter
{
    public class ClientManagerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerView _view;

        public ClientManagerPresenter(IKernel kernel, IClientManagerView view)
        {
            _kernel = kernel;
            _view = view;

            _view.addOrder += CreateNewOrder;
            _view.Back += ExitClientManager;
            //_view.lookOrder += () => ShowOrders();
        }


        public void Run()
        {
            _view.Show();
        }

        private void CreateNewOrder()
        {
            //_kernel.Get<ClientManagerAddOrderPresenter>().Run();
            new ClientManagerAddOrderFirstStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderFirstStepView>()).Run();
            _view.Close();
        }

        private void ShowOrders()
        {
            _kernel.Get<ClientManagerInspectOrderPresenter>().Run();
            _view.Close();
        }

        private void ExitClientManager()
        {
            _kernel.Get<SignInPresenter>().Run();
            _view.Close();
        }
    }
}
