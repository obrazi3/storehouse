using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerInfoDificitProductsPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IPurcpManagerInfoDificitProductsView view;
        private IDeliveryOrderServiceForPurcpManager model;

        public PurcpManagerInfoDificitProductsPresenter(IPurcpManagerInfoDificitProductsView _view,
            IDeliveryOrderServiceForPurcpManager _model, IKernel _kernel)
        {
            kernel = _kernel;
            view = _view;
            model = _model;

            view.Back += OnButtonBackClick;
        }

        public void Run()
        {
            view.SetInformation(model.GetListDificitProducts(10));
            view.Show();
        }

        private void OnButtonBackClick()
        {
            kernel.Get<PurcpManagerPresenter>().Run();
            view.Close();
        }
    }
}
