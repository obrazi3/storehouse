using System.Collections.Generic;
using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerInfoOrdersProdPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IPurcpManagerInfoOrderProdView _view;
        private readonly IDeliveryOrderServiceForPurcpManager _model;

        public PurcpManagerInfoOrdersProdPresenter(IPurcpManagerInfoOrderProdView view,
            IDeliveryOrderServiceForPurcpManager model, IKernel kernel)
        {
            this._view = view;
            this._model = model;
            this._kernel = kernel;
            
            DisplayInfo();

            this._view.Back += OnButtonCancelClick;
            this._view.RemoveOrders += OnButtonRemoveOrdersClick;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonCancelClick()
        {
            _kernel.Get<PurcpManagerPresenter>().Run();
            _view.Close();
        }

        private void OnButtonRemoveOrdersClick()
        {
            var dictCheckBoxes = _view.GetDictionaryBoxes();
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
                    _model.RemoveNotPaidOrder(order);
                }
                DisplayInfo();
                //kernel.Get<PurcpManagerPresenter>().Run();
               // view.Close();
            }
           
        }

        private void DisplayInfo()
        {
            _view.AddOrders(_model.GetListNotPaidOrders());
        }

       
    }
}
