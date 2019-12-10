using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddOrderFirstStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientManagerAddOrderFirstStepView _view;
        private IServiceForControlProductMovementInClientOrder _productMovementService;
        private ClientOrder _order;
        private bool _isNewOrder;

        public ClientManagerAddOrderFirstStepPresenter(IKernel kernel, IClientManagerAddOrderFirstStepView view
            , IServiceForControlProductMovementInClientOrder productMovementService, ClientOrder order) : this(kernel,
            view,
            productMovementService)
        {
            this._order = order;
            _isNewOrder = false;
            SetOrderInfo();
        }

        public ClientManagerAddOrderFirstStepPresenter(IKernel kernel, IClientManagerAddOrderFirstStepView view,
            IServiceForControlProductMovementInClientOrder productMovementService)
        {
            _kernel = kernel;
            _view = view;
            _productMovementService = productMovementService;
            _isNewOrder = true;

            _view.Back += Back;
            _view.NextStep += NextStep;
        }

        private void Back()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
            if (!_isNewOrder)
                _productMovementService.CancelEditing(_order.OrderId);
        }

        public void Run()
        {
            _view.Show();
        }

        private void NextStep()
        {
            IServiceForFilingPersonInfoInClientOrder serviceForPersonalInfo =
                _kernel.Get<IServiceForFilingPersonInfoInClientOrder>();
            if (_isNewOrder)
            {
                _order = new ClientOrder();
                serviceForPersonalInfo.SetClientOrder(_order);
                serviceForPersonalInfo.InitializeOrder();
            }
            else
                serviceForPersonalInfo.SetClientOrder(_order);

            _productMovementService.AddClientOrder(_order);
            ClientInformation info = new ClientInformation();

            if (_view.IsDelivery())
            {
                HomeAddress address = new HomeAddress();
                address.City = _view.GetCity();
                address.Street = _view.GetStreet();
                address.FlatNumber = _view.GetFlat();
                address.FloorNumber = _view.GetFloorNumber();
                address.HomeNumber = _view.GetHouseNumber();
                address.PavilionNumber = _view.GetPavilion();
                address.PorchNumber = _view.GetPorchNumber();
                info.Address = address;
                _order.IsDelivery = true;
            }
            else
                _order.IsDelivery = false;

            info.Name = _view.GetName();
            info.Patronymic = _view.GetPatronymic();
            info.Surname = _view.GetSurname();
            info.EmailAddress = _view.GetEmailAddress();
            info.PhoneNumber = _view.GetPhoneNumber();

            serviceForPersonalInfo.AddClientInfo(info);

            new ClientManagerAddOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(),
                _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                _order).Run();
            _view.Close();
        }

        private void SetOrderInfo()
        {
            _view.SetName(_order.ClientInfo.Name);
            _view.SetSurname(_order.ClientInfo.Surname);
            _view.SetPatronymic(_order.ClientInfo.Patronymic);
            _view.SetPhoneNumber(_order.ClientInfo.PhoneNumber);
            _view.SetEmailAddress(_order.ClientInfo.EmailAddress);

            if (_order.IsDelivery)
            {
                _view.SetCity(_order.ClientInfo.Address.City);
                _view.SetStreet(_order.ClientInfo.Address.Street);
                _view.SetHouseNumber(_order.ClientInfo.Address.HomeNumber);
                _view.SetPavilion(_order.ClientInfo.Address.PavilionNumber);
                _view.SetFlat(_order.ClientInfo.Address.FlatNumber);
                _view.SetFloorNumber(_order.ClientInfo.Address.FloorNumber);
                _view.SetPorchNumber(_order.ClientInfo.Address.PorchNumber);
                _view.SetCity(_order.ClientInfo.Address.City);
                _view.SetDelivery(true);
            }
            else
                _view.SetDelivery(false);
        }
    }
}
