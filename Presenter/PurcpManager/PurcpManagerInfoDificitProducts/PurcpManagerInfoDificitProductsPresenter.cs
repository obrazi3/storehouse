using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerInfoDificitProductsPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IPurcpManagerInfoDificitProductsView _view;
        private IDeliveryOrderServiceForPurcpManager _model;

        public PurcpManagerInfoDificitProductsPresenter(IPurcpManagerInfoDificitProductsView view,
            IDeliveryOrderServiceForPurcpManager model, IKernel kernel)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;

            this._view.Back += OnButtonBackClick;
        }

        public void Run()
        {
            _view.SetInformation(_model.GetListDificitProducts(10));
            _view.Show();
        }

        private void OnButtonBackClick()
        {
            _kernel.Get<PurcpManagerPresenter>().Run();
            _view.Close();
        }
    }
}
