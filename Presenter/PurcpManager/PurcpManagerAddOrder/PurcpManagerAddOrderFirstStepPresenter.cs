using System;
using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerAddOrderFirstStepPresenter : IPresenter
    {
        private readonly IPurcpManagerAddOrderFirstStepView _view;
        private readonly IKernel _kernel;

        public PurcpManagerAddOrderFirstStepPresenter(IPurcpManagerAddOrderFirstStepView view, IKernel kernel)
        {
            this._view = view;
            this._kernel = kernel;

            this._view.NextStep += OnButtonNextStepClick;
            this._view.Back += OnButtonBackClick;
        }

        public PurcpManagerAddOrderFirstStepPresenter(IPurcpManagerAddOrderFirstStepView view, IKernel kernel,
            ProductProviderOrder order) : this(view,
            kernel)
        {
            this._view.OrganizationName = order.Provider.Name;
            this._view.Email = order.Provider.Email;
            this._view.BankAccount = order.Provider.BankAccountNumber;
            this._view.ContactNumber = order.Provider.ContactNumber;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonBackClick()
        {
            _kernel.Get<PurcpManagerPresenter>().Run();
            _view.Close();
        }

        private void OnButtonNextStepClick()
        {
            ProductProviderOrder order = new ProductProviderOrder();
            order.Provider.Email = _view.Email;
            order.Provider.Name = _view.OrganizationName;
            order.Provider.ContactNumber = _view.ContactNumber;
            order.Provider.BankAccountNumber = _view.BankAccount;
            /// Console.WriteLine(DateTime.Now);
            order.OrderDate = DateTime.Now;
            new PurcpManagerAddOrderSecondStepPresenter(_kernel.Get<IPurcpManagerAddOrderSecondStepView>(),
                _kernel.Get<IDeliveryOrderServiceForPurcpManager>(), _kernel, order).Run();
            _view.Close();
            //TO-DO
            //Ninject
        }
    }
}
