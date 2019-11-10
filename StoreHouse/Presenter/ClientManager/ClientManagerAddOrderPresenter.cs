using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderView _view;
        private IClientOrder _order;

        public ClientManagerAddOrderPresenter(IKernel kernel, IClientManagerAddOrderView view, IClientOrder order) : this(kernel, view)
        {
            _order = order;
            setOrderInfo();

        }

        public ClientManagerAddOrderPresenter(IKernel kernel, IClientManagerAddOrderView view)
        {
            _kernel = kernel;
            _view = view;

            _view.Back += () => Back();
            _view.NextStep += () => NextStep();
        }

        private void Back()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }

        private void NextStep()
        {
            if (_order == null)
                _order = _kernel.Get<IClientOrder>();

            _order.Name = _view.GetName();
            _order.Surname = _view.GetSurname();
            _order.Patronymic = _view.GetPatronymic();
            _order.PhoneNumber = _view.GetPhoneNumber();
            _order.EmailAddress = _view.GetEmailAddress();
            _order.City = _view.GetCity();
            _order.Street = _view.GetStreet();
            _order.HouseNumber = _view.GetHouseNumber();
            _order.Pavilion = _view.GetPavilion();
            _order.Flat = _view.GetFlat();

            new ClientManagerAddOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(), _order).Run();
            _view.Close();
        }

        private void setOrderInfo()
        {
            _view.SetName(_order.Name);
            _view.SetSurname(_order.Surname);
            _view.SetPatronymic(_order.Patronymic);
            _view.SetPhoneNumber(_order.PhoneNumber);
            _view.SetEmailAddress(_order.EmailAddress);
            _view.SetCity(_order.City);
            _view.SetStreet(_order.Street);
            _view.SetHouseNumber(_order.HouseNumber);
            _view.SetPavilion(_order.Pavilion);
            _view.SetFlat(_order.Flat);
        }
    }
}
