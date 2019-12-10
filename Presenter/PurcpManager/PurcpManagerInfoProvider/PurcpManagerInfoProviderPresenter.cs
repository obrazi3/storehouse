using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerInfoProviderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IPurcpManagerInfoProviderView _view;
        private IDeliveryOrderServiceForPurcpManager _model;

        public PurcpManagerInfoProviderPresenter(IPurcpManagerInfoProviderView view,
            IDeliveryOrderServiceForPurcpManager model, IKernel kernel)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;

            this._view.Back += OnButtonBackClick;
            this._view.SearchProvider += OnButtonSearchClick;
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

        private void OnButtonSearchClick()
        {
            int id = _view.GetProviderNumber();
            var provider = _model.GetProductProvider(id);
            _view.SetInfoProvider(provider);
        }
    }
}
