using System;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerEditOrderFirstStepPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IClientManagerAddOrderFirstStepView view;
        private IServiceForEditingClientOrder editor;
        private ClientOrder order;

        public ClientManagerEditOrderFirstStepPresenter(IKernel _kernel,
            IClientManagerAddOrderFirstStepView _view, IServiceForEditingClientOrder _editor, ClientOrder _order)
        {
            kernel = _kernel;
            view = _view;
            order = _order;
            editor = _editor;

            editor.AddClientOrder(order);

            InitializeView();

            view.Back += OnButtonBackClick;
            view.NextStep += OnButtonNextStepClick;
            view.SetFormName("Редактирование данных заказчика");
        }

        public void Run()
        {
            view.Show();
        }

        private void InitializeView()
        {
            view.SetDelivery(order.isDelivery);
            if (order.isDelivery)
            {
                var address = order.ClientInfo.Address;
                view.SetCity((string)address.City.Clone());
                view.SetStreet((string)address.Street.Clone());
                view.SetHouseNumber((string)address.HomeNumber.Clone());
                view.SetPavilion((string)address.PavilionNumber.Clone());
                view.SetPorchNumber((string)address.PorchNumber.Clone());
                view.SetFloorNumber((string)address.FloorNumber.Clone());
                view.SetFlat((string)address.FlatNumber.Clone());
            }

            var clientInfo = order.ClientInfo;
            view.SetName((string)clientInfo.Name.Clone());
            view.SetSurname((string)clientInfo.Surname.Clone());
            view.SetPatronymic((string)clientInfo.Patronymic.Clone());
            view.SetPhoneNumber((string)clientInfo.PhoneNumber.Clone());
            view.SetEmailAddress((string)clientInfo.EmailAddress.Clone());
        }

        private void OnButtonBackClick()
        {
            editor.CancelEditing(order.OrderId);
            new ClientManagerInspectOrderPresenter(kernel, kernel.Get<IClientManagerInspectOrderView>(),
                kernel.Get<IClientOrderServiceForClientManager>(), order).Run();
            view.Close();
        }

        private void OnButtonNextStepClick()
        {
            IServiceForFilingClientOrder serviceForOrder = kernel.Get<IServiceForFilingClientOrder>();

            serviceForOrder.SetClientOrder(order);

            ClientInformation info = new ClientInformation();

            if (view.IsDelivery())
            {
                HomeAddress address = new HomeAddress();
                address.City = view.GetCity();
                address.Street = view.GetStreet();
                address.FlatNumber = view.GetFlat();
                address.FloorNumber = view.GetFloorNumber();
                address.HomeNumber = view.GetHouseNumber();
                address.PavilionNumber = view.GetPavilion();
                address.PorchNumber = view.GetPorchNumber();
                info.Address = address;
                order.isDelivery = true;
            }
            else
                order.isDelivery = false;

            info.Name = view.GetName();
            info.Patronymic = view.GetPatronymic();
            info.Surname = view.GetSurname();
            info.EmailAddress = view.GetEmailAddress();
            info.PhoneNumber = view.GetPhoneNumber();

            serviceForOrder.AddClientInfo(info);

            new ClientManagerEditOrderSecondStepPresenter(kernel, kernel.Get<IClientManagerAddOrderSecondStepView>(),
                    kernel.Get<IClientOrderServiceForClientManager>(), kernel.Get<IServiceForEditingClientOrder>(),
                    order)
                .Run();
            view.Close();
        }
    }
}
