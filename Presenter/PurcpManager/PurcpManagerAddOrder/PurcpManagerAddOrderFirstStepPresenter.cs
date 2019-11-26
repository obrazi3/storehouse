using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerAddOrderFirstStepPresenter : IPresenter
    {
        private readonly IPurcpManagerAddOrderFirstStepView view;
        private readonly IKernel kernel;

        public PurcpManagerAddOrderFirstStepPresenter(IPurcpManagerAddOrderFirstStepView _view, IKernel _kernel)
        {
            view = _view;
            kernel = _kernel;

            view.NextStep += OnButtonNextStepClick;
            view.Back += OnButtonBackClick;
        }

        public PurcpManagerAddOrderFirstStepPresenter(IPurcpManagerAddOrderFirstStepView _view, IKernel _kernel,
            ProductProviderOrder order) : this(_view,
            _kernel)
        {
            view.OrganizationName = order.Provider.Name;
            view.Email = order.Provider.Email;
            view.BankAccount = order.Provider.BankAccountNumber;
            view.ContactNumber = order.Provider.ContactNumber;
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonBackClick()
        {
            view.Close();
            kernel.Get<PurcpManagerPresenter>().Run();
        }

        private void OnButtonNextStepClick()
        {
            ProductProviderOrder order = new ProductProviderOrder();
            order.Provider.Email = view.Email;
            order.Provider.Name = view.OrganizationName;
            order.Provider.ContactNumber = view.ContactNumber;
            order.Provider.BankAccountNumber = view.BankAccount;
            new PurcpManagerAddProductToOrderPresenter(kernel.Get<IPurcpManagerAddProductInOrderView>(), kernel, order).Run();
            view.Close();
            //TO-DO
            //Ninject
        }
    }
}
