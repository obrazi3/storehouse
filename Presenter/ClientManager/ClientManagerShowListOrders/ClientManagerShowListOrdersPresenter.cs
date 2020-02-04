using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerShowListOrdersPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientOrderServiceForBooker _model;
        private IClientManagerShowListOrdersView _view;


        public ClientManagerShowListOrdersPresenter(IKernel kernel, IClientOrderServiceForBooker model,
            IClientManagerShowListOrdersView view)
        {
            this._kernel = kernel;
            this._model = model;
            this._view = view;

            this._view.Back += OnButtonBackClick;
            this._view.SetInformation(this._model.GetListNotPaidClientOrders());
        }

        public void Run()
        {
            _view.Show();
        }


        private void OnButtonBackClick()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }
    }
}
