using Model;
using Ninject;

namespace Presenter
{
    internal class ClientManagerAddOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderSecondStepView _view;
        private IClientOrder _order;

        public ClientManagerAddOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view)
        {
            _kernel = kernel;
            _view = view;

            _view.AddProduct += () => AddProduct();
            _view.Back += () => Back();
            _view.Cancel += () => Cancel();
        }

        public ClientManagerAddOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view, IClientOrder order) : this(kernel, view)
        {
            _order = order;
        }

        private void Cancel()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

        private void Back()
        {
            // Uncomment when view will be added.
            // new ClientManagerAddOrderPresenter(_kernel, new ClientManagerAddOrderView(_kernel.Get<ApplicationContext>()), _order).Run();
            _view.Close();
        }

        private void AddProduct()
        {
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
