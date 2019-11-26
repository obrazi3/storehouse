using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerRemoveProviderPresenter:IPresenter
    {
        private IPurcpManagerRemoveProviderView view;
        private IDeliveryOrderServiceForPurcpManager model;
        private readonly IKernel kernel;

        public PurcpManagerRemoveProviderPresenter(IPurcpManagerRemoveProviderView _view,
            IDeliveryOrderServiceForPurcpManager _model, IKernel _kernel)
        {
            view = _view;
            model = _model;
            kernel = _kernel;

            view.RemoveProvider += OnButtonRemoveProviderClick;
            view.Back += OnButtonBackClick;
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

        private void OnButtonRemoveProviderClick()
        {
            model.RemoveProductProvider(view.GetProviderId());
            OnButtonBackClick();
        }
    }
}
