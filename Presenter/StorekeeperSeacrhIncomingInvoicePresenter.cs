using System;
using Model;
using Ninject;

namespace Presenter
{
    public class StorekeeperSeacrhIncomingInvoicePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IStorekeeperSearchInvoiceView _view;
        private readonly IModel _model;

        public StorekeeperSeacrhIncomingInvoicePresenter(IKernel kernel, IStorekeeperSearchIncomingInvoiceView view, IModel model)
        {
            _kernel = kernel;
            _view = view;
            _model = model;

            _view.Search += () => SearchInvoice();
            _view.ShowInvoiceContent += () => ShowInvoiceContent();
            _view.ConfirmAdmission += () => ConfirmAdmission();
            _view.Back += () => Back();
        }

        private bool SearchInvoice()
        {
            int number = 0;
            try
            {
                number = int.Parse((_view.GetNumberInvoice()));
            }
            catch (Exception e)
            {
                return false;
            }
            IBriefInvoiceInfo info = _model.findIncomingInvoice(number);
            if (info != null)
            {
                _view.SetName(info.getName());
                _view.SetNumberInvoice(info.getNumber());
                _view.SetCost(info.getCost());
                return true;
            }
            else
                return false;
        }

        private void ShowInvoiceContent()
        {

        }

        private void ConfirmAdmission()
        {

        }

        private void Back()
        {
            _kernel.Get<StorekeeperPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
