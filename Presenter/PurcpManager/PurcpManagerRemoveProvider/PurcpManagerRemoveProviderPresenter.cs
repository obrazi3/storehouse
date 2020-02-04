using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerRemoveProviderPresenter:IPresenter
    {
        private IPurcpManagerRemoveProviderView _view;
        private IDeliveryOrderServiceForPurcpManager _model;
        private readonly IKernel _kernel;

        public PurcpManagerRemoveProviderPresenter(IPurcpManagerRemoveProviderView view,
            IDeliveryOrderServiceForPurcpManager model, IKernel kernel)
        {
            this._view = view;
            this._model = model;
            this._kernel = kernel;

            this._view.RemoveProvider += OnButtonRemoveProviderClick;
            this._view.Back += OnButtonBackClick;
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

        private void OnButtonRemoveProviderClick()
        {
            _model.RemoveProductProvider(_view.GetProviderId());
            OnButtonBackClick();
        }
    }
}
