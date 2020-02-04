using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerEditOrderFirstStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientManagerAddOrderFirstStepView _view;
        private IServiceForControlProductMovementInClientOrder _editor;
        private ClientOrder _order;

        public ClientManagerEditOrderFirstStepPresenter(IKernel kernel,
            IClientManagerAddOrderFirstStepView view, IServiceForControlProductMovementInClientOrder editor, ClientOrder order)
        {
            this._kernel = kernel;
            this._view = view;
            this._order = order;
            this._editor = editor;

            this._editor.AddClientOrder(this._order);

            InitializeView();

            this._view.Back += OnButtonBackClick;
            this._view.NextStep += OnButtonNextStepClick;
            this._view.SetFormName("Редактирование данных заказчика");
        }

        public void Run()
        {
            _view.Show();
        }

        private void InitializeView()
        {
            _view.SetDelivery(_order.IsDelivery);
            if (_order.IsDelivery)
            {
                var address = _order.ClientInfo.Address;
                _view.SetCity((string)address.City.Clone());
                _view.SetStreet((string)address.Street.Clone());
                _view.SetHouseNumber((string)address.HomeNumber.Clone());
                _view.SetPavilion((string)address.PavilionNumber.Clone());
                _view.SetPorchNumber((string)address.PorchNumber.Clone());
                _view.SetFloorNumber((string)address.FloorNumber.Clone());
                _view.SetFlat((string)address.FlatNumber.Clone());
            }

            var clientInfo = _order.ClientInfo;
            _view.SetName((string)clientInfo.Name.Clone());
            _view.SetSurname((string)clientInfo.Surname.Clone());
            _view.SetPatronymic((string)clientInfo.Patronymic.Clone());
            _view.SetPhoneNumber((string)clientInfo.PhoneNumber.Clone());
            _view.SetEmailAddress((string)clientInfo.EmailAddress.Clone());
        }

        private void OnButtonBackClick()
        {
            _editor.CancelEditing(_order.OrderId);
            new ClientManagerInspectOrderPresenter(_kernel, _kernel.Get<IClientManagerInspectOrderView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(), _order).Run();
            _view.Close();
        }

        private void OnButtonNextStepClick()
        {
            IServiceForFilingPersonInfoInClientOrder serviceForOrder = _kernel.Get<IServiceForFilingPersonInfoInClientOrder>();

            serviceForOrder.SetClientOrder(_order);

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

            serviceForOrder.AddClientInfo(info);

            new ClientManagerEditOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                    _kernel.Get<IClientOrderServiceForClientManager>(), _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                    _order)
                .Run();
            _view.Close();
        }
    }
}
