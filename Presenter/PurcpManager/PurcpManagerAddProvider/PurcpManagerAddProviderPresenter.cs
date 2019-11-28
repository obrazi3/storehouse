using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerAddProviderPresenter : IPresenter
    {
        private readonly IPurcpManagerAddProviderView view;
        private readonly IDeliveryOrderServiceForPurcpManager model;
        private readonly IKernel kernel;

        public PurcpManagerAddProviderPresenter(IPurcpManagerAddProviderView _view,
            IDeliveryOrderServiceForPurcpManager _model, IKernel _kernel)
        {
            view = _view;
            model = _model;
            kernel = _kernel;

            view.AddProvider += () => OnButtonAddProviderClick();
            view.Back += () => OnButtonBackClick();
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonBackClick()
        {
            kernel.Get<PurcpManagerPresenter>().Run();
            view.Close();
        }

        private void OnButtonAddProviderClick()
        {
            ProductProvider provider = new ProductProvider();
            provider.Email = view.Email;
            provider.Name = view.ProviderName;
            provider.ContactNumber = view.PhoneNumber;
            provider.BankAccountNumber = view.BankAccount;

            var listCatergories = view.GetListProductCategories();
            foreach (var category in listCatergories)
            {
                provider.AddProductCategory(category);
            }

            model.AddProductProvider(provider);

            kernel.Get<PurcpManagerPresenter>().Run();
            view.Close();
        }
    }
}
