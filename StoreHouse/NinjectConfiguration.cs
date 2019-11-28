using Ninject.Modules;
using Model;
using Presenter;
using System.Windows.Forms;

namespace View
{
    public class NinjectConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<IModel>().To<Model.Model>();

            Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            Bind<IProviderOrderRepository>().To<ProviderOrderRepository>().InSingletonScope();

            Bind<IProductProviderRepository>().To<ProductProviderRepository>().InSingletonScope();

            Bind<IStorehouseRepository>().To<StorehouseRepository>().InSingletonScope();
            Bind<IStorehouseServiceForDeliveryOrderService>().To<StorehouseService>().InSingletonScope();
            Bind<IStorehouseServiceForClientOrderService>().To<StorehouseService>().InSingletonScope();

            Bind<IDeliveryOrderServiceForBooker>().To<DeliveryOrderService>().InSingletonScope();
            Bind<IDeliveryOrderServiceForStorekeeper>().To<DeliveryOrderService>().InSingletonScope();
            Bind<IDeliveryOrderServiceForPurcpManager>().To<DeliveryOrderService>().InSingletonScope();

            Bind<IBankForClientOrderService>().To<Bank>().InSingletonScope();
            Bind<IBankForDeliveryOrderService>().To<Bank>().InSingletonScope();

            Bind<ISignInView>().To<SignInView>();

            Bind<IBookerView>().To<BookerView>();
            Bind<IBookerShowNotPaidProviderOrdersView>().To<BookerShowNotPaidProviderOrdersView>();
            Bind<IBookerPayProviderOrderView>().To<BookerPayProviderOrderView>();

            Bind<ICourierView>().To<CourierView>();

            Bind<IStorekeeperView>().To<StorekeeperView>();
            Bind<IStorekeeperSearchIncomingInvoiceView>().To<StorekeeperSearchIncomingInvoiceView>();
            Bind<IStorekeeperSearchSalesInvoiceView>().To<StorekeeperSearchSalesInvoiceView>();

            Bind<IClientManagerView>().To<ClientManagerView>();
            Bind<IClientManagerAddOrderView>().To<ClientManagerAddOrderView>();
            Bind<IClientManagerAddOrderSecondStepView>().To<ClientManagerAddOrderSecondStepView>();
            Bind<IClientManagerInspectOrderView>().To<ClientManagerInspectOrderView>();

            // kernel.Bind<IClientOrder>().To<ClientOrder>();

            Bind<ICourierGetOrderView>().To<CourierGetOrderView>();

            Bind<IPurcpManagerView>().To<PurcpManagerView>();
            Bind<IPurcpManagerAddProviderView>().To<PurcpManagerAddProviderView>();
            Bind<IPurcpManagerRemoveProviderView>().To<PurcpManagerRemoveProviderView>();
            Bind<IPurcpManagerInfoProviderView>().To<PurcpManagerInfoProviderView>();
            Bind<IPurcpManagerInfoDificitProductsView>().To<PurcpManagerInfoDificitProductsView>();
            Bind<IPurcpManagerAddOrderFirstStepView>().To<PurcpManagerAddOrderFirstStepView>();
            Bind<IPurcpManagerAddOrderSecondStepView>().To<PurcpManagerAddOrderSecondStepView>();
            Bind<IPurcpManagerAddProductInOrderView>().To<PurcpManagerAddProductInOrderView>();
            Bind<IPurcpManagerInfoOrderProdView>().To<PurcpManagerInfoOrdersProdView>();


            Bind<SignInPresenter>().ToSelf();

            Bind<BookerPresenter>().ToSelf();
            Bind<BookerShowNotPaidProviderOrdersPresenter>().ToSelf();
            Bind<BookerPayProviderOrderPresenter>().ToSelf();

            Bind<StorekeeperPresenter>().ToSelf();
            Bind<StorekeeperSeacrhIncomingInvoicePresenter>().ToSelf();
            Bind<StorekeeperSearchSalesInvoicePresenter>().ToSelf();

            Bind<ClientManagerPresenter>().ToSelf();
            Bind<ClientManagerAddOrderPresenter>().ToSelf();
            Bind<ClientManagerInspectOrderPresenter>().ToSelf();

            Bind<CourierPresenter>().ToSelf();
            Bind<CourierGetOrderPresenter>().ToSelf();

            Bind<PurcpManagerPresenter>().ToSelf();
            Bind<PurcpManagerAddProviderPresenter>().ToSelf();
            Bind<PurcpManagerRemoveProviderPresenter>().ToSelf();
            Bind<PurcpManagerInfoProviderPresenter>().ToSelf();
            Bind<PurcpManagerInfoDificitProductsPresenter>().ToSelf();
            Bind<PurcpManagerInfoOrdersProdPresenter>().ToSelf();
            Bind<PurcpManagerAddOrderFirstStepPresenter>().ToSelf();
            Bind<PurcpManagerAddProductToOrderPresenter>().ToSelf();
            Bind<PurcpManagerAddOrderSecondStepPresenter>().ToSelf();
        }
    }
}
