using System.Windows.Forms;
using Model;
using Ninject;
using View;

namespace Presenter
{
    public class PurcpManagerAddProductToOrderPresenter : IPresenter
    {
        private readonly IPurcpManagerAddProductInOrderView view;
        private readonly IKernel kernel;
        private ProductProviderOrder order;

        public PurcpManagerAddProductToOrderPresenter(IPurcpManagerAddProductInOrderView _view, IKernel _kernel,
            ProductProviderOrder _order)
        {
            view = _view;
            kernel = _kernel;
            order = _order;

            view.AddProduct += OnButtonAddProductClick;
            view.Back += OnButtonCancelClick;
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonCancelClick()
        {
            new PurcpManagerAddOrderFirstStepPresenter(kernel.Get<IPurcpManagerAddOrderFirstStepView>(), kernel, order)
                .Run();
            view.Close();
            //TO-DO
            //Ninject
        }

        private void OnButtonAddProductClick()
        {
            ProductFromLot product = new ProductFromLot();

            product.Lot.ProductionDate = view.ProductionDate;
            product.Lot.QuantityProduct = view.QuantityProduct;
            product.Measure = view.Measure;
            product.Price = view.Price;
            product.ExpirationDate = view.ExpirationDate;
            product.ProduceCountry = view.ProduceCountry;
            product.ProductCategory = view.ProductCategory;
            product.ProductGroup = view.ProductGroup;
            product.ProductName = view.ProductName;
            new PurcpManagerAddOrderSecondStepPresenter(kernel.Get<IPurcpManagerAddOrderSecondStepView>(),
                kernel.Get<IDeliveryOrderServiceForPurcpManager>(), kernel, order).Run();
            view.Close();
            //TO-DO
            //Ninject
        }
    }
}
