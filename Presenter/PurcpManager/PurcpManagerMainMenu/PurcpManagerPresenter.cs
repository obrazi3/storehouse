using Ninject;

namespace Presenter
{
    public class PurcpManagerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IPurcpManagerView _view;

        public PurcpManagerPresenter(IKernel kernel, IPurcpManagerView view)
        {
            _kernel = kernel;
            _view = view;

            _view.AddOrder += OnButtonAddOrderClick;
            _view.AddProvider += OnButtonAddProviderClick;
            _view.RemoveProvider += OnButtonRemoveProviderClick;
            _view.ViewInfoProvider += OnButtonViewInfoProviderClick;
            _view.ViewInfoEndedProd += OnButtonViewInfoEndedProdClick;
            _view.ViewInfoOrderProd += OnButtonViewInfoOrderProdClick;
            _view.Back += OnButtonBackClick;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonViewInfoOrderProdClick()
        {
            _kernel.Get<PurcpManagerInfoOrdersProdPresenter>().Run();
            _view.Close();
        }

        private void OnButtonAddOrderClick()
        {
            new PurcpManagerAddOrderFirstStepPresenter(_kernel.Get<IPurcpManagerAddOrderFirstStepView>(),_kernel).Run();
            _view.Close();
        }

        private void OnButtonViewInfoProviderClick()
        {
            _kernel.Get<PurcpManagerInfoProviderPresenter>().Run();
            _view.Close();
        }

        private void OnButtonAddProviderClick()
        {
            _kernel.Get<PurcpManagerAddProviderPresenter>().Run();
            _view.Close();
        }

        private void OnButtonRemoveProviderClick()
        {
            _kernel.Get<PurcpManagerRemoveProviderPresenter>().Run();
            _view.Close();
        }

        private void OnButtonViewInfoEndedProdClick()
        {
            _kernel.Get<PurcpManagerInfoDificitProductsPresenter>().Run();
            _view.Close();
        }

        private void OnButtonBackClick()
        {
            _kernel.Get<SignInPresenter>().Run();
            _view.Close();
        }
    }
}
