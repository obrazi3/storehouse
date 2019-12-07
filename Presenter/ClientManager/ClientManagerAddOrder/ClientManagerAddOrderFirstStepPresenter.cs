using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddOrderFirstStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientManagerAddOrderFirstStepView _view;
        private IServiceForControlProductMovementInClientOrder _productMovementService;
        private ClientOrder order;
        private bool isNewOrder;

        public ClientManagerAddOrderFirstStepPresenter(IKernel kernel, IClientManagerAddOrderFirstStepView view
            , IServiceForControlProductMovementInClientOrder productMovementService, ClientOrder order) : this(kernel,
            view,
            productMovementService)
        {
            this.order = order;
            isNewOrder = false;
            setOrderInfo();
        }

        public ClientManagerAddOrderFirstStepPresenter(IKernel kernel, IClientManagerAddOrderFirstStepView view,
            IServiceForControlProductMovementInClientOrder productMovementService)
        {
            _kernel = kernel;
            _view = view;
            _productMovementService = productMovementService;
            isNewOrder = true;

            _view.Back += Back;
            _view.NextStep += NextStep;
        }

        private void Back()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
            if (!isNewOrder)
                _productMovementService.CancelEditing(order.OrderId);
        }

        public void Run()
        {
            _view.Show();
        }

        private void NextStep()
        {
            IServiceForFilingPersonInfoInClientOrder serviceForPersonalInfo =
                _kernel.Get<IServiceForFilingPersonInfoInClientOrder>();
            if (isNewOrder)
            {
                order = new ClientOrder();
                serviceForPersonalInfo.SetClientOrder(order);
                serviceForPersonalInfo.InitializeOrder();
            }
            else
                serviceForPersonalInfo.SetClientOrder(order);

            _productMovementService.AddClientOrder(order);
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
                order.isDelivery = true;
            }
            else
                order.isDelivery = false;

            info.Name = _view.GetName();
            info.Patronymic = _view.GetPatronymic();
            info.Surname = _view.GetSurname();
            info.EmailAddress = _view.GetEmailAddress();
            info.PhoneNumber = _view.GetPhoneNumber();

            serviceForPersonalInfo.AddClientInfo(info);

            new ClientManagerAddOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(),
                _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                order).Run();
            _view.Close();
        }

        private void setOrderInfo()
        {
            _view.SetName(order.ClientInfo.Name);
            _view.SetSurname(order.ClientInfo.Surname);
            _view.SetPatronymic(order.ClientInfo.Patronymic);
            _view.SetPhoneNumber(order.ClientInfo.PhoneNumber);
            _view.SetEmailAddress(order.ClientInfo.EmailAddress);

            if (order.isDelivery)
            {
                _view.SetCity(order.ClientInfo.Address.City);
                _view.SetStreet(order.ClientInfo.Address.Street);
                _view.SetHouseNumber(order.ClientInfo.Address.HomeNumber);
                _view.SetPavilion(order.ClientInfo.Address.PavilionNumber);
                _view.SetFlat(order.ClientInfo.Address.FlatNumber);
                _view.SetFloorNumber(order.ClientInfo.Address.FloorNumber);
                _view.SetPorchNumber(order.ClientInfo.Address.PorchNumber);
                _view.SetCity(order.ClientInfo.Address.City);
                _view.SetDelivery(true);
            }
            else
                _view.SetDelivery(false);
        }
    }
}
