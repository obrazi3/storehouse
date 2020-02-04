using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerAddProviderPresenter : IPresenter
    {
        private readonly IPurcpManagerAddProviderView _view;
        private readonly IDeliveryOrderServiceForPurcpManager _model;
        private readonly IKernel _kernel;

        public PurcpManagerAddProviderPresenter(IPurcpManagerAddProviderView view,
            IDeliveryOrderServiceForPurcpManager model, IKernel kernel)
        {
            this._view = view;
            this._model = model;
            this._kernel = kernel;

            this._view.AddProvider += () => OnButtonAddProviderClick();
            this._view.Back += () => OnButtonBackClick();
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

        private void OnButtonAddProviderClick()
        {
            ProductProvider provider = new ProductProvider();
            provider.Email = _view.Email;
            provider.Name = _view.ProviderName;
            provider.ContactNumber = _view.PhoneNumber;
            provider.BankAccountNumber = _view.BankAccount;

            var listCatergories = _view.GetListProductCategories();
            foreach (var category in listCatergories)
            {
                provider.AddProductCategory(category);
            }

            _model.AddProductProvider(provider);

            _kernel.Get<PurcpManagerPresenter>().Run();
            _view.Close();
        }
    }
}
