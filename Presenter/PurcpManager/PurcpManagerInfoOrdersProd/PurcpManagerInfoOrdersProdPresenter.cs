using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerInfoOrdersProdPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private readonly IPurcpManagerInfoOrderProdView view;
        private readonly IDeliveryOrderServiceForPurcpManager model;

        public PurcpManagerInfoOrdersProdPresenter(IPurcpManagerInfoOrderProdView _view,
            IDeliveryOrderServiceForPurcpManager _model, IKernel _kernel)
        {
            view = _view;
            model = _model;
            kernel = _kernel;
            
            DisplayInfo();

            view.Back += OnButtonCancelClick;
            view.RemoveOrders += OnButtonRemoveOrdersClick;
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonCancelClick()
        {
            kernel.Get<PurcpManagerPresenter>().Run();
            view.Close();
        }

        private void OnButtonRemoveOrdersClick()
        {
            var dictCheckBoxes = view.GetDictionaryBoxes();
            var markedOrders = new List<int>();
            bool isMarked = false;

            foreach (var checkBox in dictCheckBoxes)
            {
                if (checkBox.Value.Checked)
                {
                    isMarked = true;
                    markedOrders.Add(checkBox.Key);
                }
            }

            if (isMarked)
            {
                foreach (var order in markedOrders)
                {
                    model.RemoveNotPaidOrder(order);
                }
                DisplayInfo();
                //kernel.Get<PurcpManagerPresenter>().Run();
               // view.Close();
            }
           
        }

        private void DisplayInfo()
        {
            view.AddOrders(model.GetListNotPaidOrders());
        }

       
    }
}
