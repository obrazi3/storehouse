using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerShowListOrdersPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IClientOrderServiceForBooker model;
        private IClientManagerShowListOrdersView view;


        public ClientManagerShowListOrdersPresenter(IKernel _kernel, IClientOrderServiceForBooker _model,
            IClientManagerShowListOrdersView _view)
        {
            kernel = _kernel;
            model = _model;
            view = _view;

            view.Back += OnButtonBackClick;
            view.SetInformation(model.GetListNotPaidClientOrders());
        }

        public void Run()
        {
            view.Show();
        }


        private void OnButtonBackClick()
        {
            kernel.Get<ClientManagerPresenter>().Run();
            view.Close();
        }
    }
}
