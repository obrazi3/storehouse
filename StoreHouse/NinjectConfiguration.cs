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

            Bind<IClientOrderServiceForBooker>().To<ClientOrderService>().InSingletonScope();
            Bind<IClientOrderServiceForCourier>().To<ClientOrderService>().InSingletonScope();
            Bind<IClientOrderServiceForStorekeeper>().To<ClientOrderService>().InSingletonScope();
            Bind<IClientOrderServiceForClientManager>().To<ClientOrderService>().InSingletonScope();

            Bind<IServiceForFilingPersonInfoInClientOrder>().To<ServiceForFillingPersonInfoInClientOrder>();
            Bind<IServiceForControlProductMovementInClientOrder>().To<ServiceForControlProductMovementInClientOrder>().InSingletonScope();
            Bind<IServiceForAddingProductsInClientOrder>().To<ServiceForAddingProductsInClientOrder>();
            Bind<IServiceForStorehouseProduct>().To<ServiceForStorehouseProduct>();

            Bind<IBankForClientOrderService>().To<Bank>().InSingletonScope();
            Bind<IBankForDeliveryOrderService>().To<Bank>().InSingletonScope();

            Bind<IClientOrderRepository>().To<ClientOrderRepository>().InSingletonScope();

            Bind<ISignInView>().To<SignInView>();

            Bind<IBookerView>().To<BookerView>();
            Bind<IBookerShowNotPaidProviderOrdersView>().To<BookerShowNotPaidProviderOrdersView>();
            Bind<IBookerPayProviderOrderView>().To<BookerPayProviderOrderView>();
            Bind<IBookerShowNotPaidClientOrdersView>().To<BookerShowNotPaidClientOrdersView>();
            Bind<IBookerCheckPaymentClientOrderView>().To<BookerCheckPaymentClientOrderView>();

            Bind<ICourierView>().To<CourierView>();

            Bind<IStorekeeperView>().To<StorekeeperView>();
            Bind<IStorekeeperSearchProviderOrderView>().To<StorekeeperSearchProviderOrderView>();
            Bind<IStorekeeperSearchClientOrderView>().To<StorekeeperSearchClientOrderView>();

            Bind<IClientManagerView>().To<ClientManagerView>();
            Bind<IClientManagerAddOrderFirstStepView>().To<ClientManagerAddOrderFirstStepView>();
            Bind<IClientManagerAddOrderSecondStepView>().To<ClientManagerAddOrderSecondStepView>();
            Bind<IClientManagerInspectOrderView>().To<ClientManagerInspectOrderView>();
            Bind<IClientManagerProductCatalogView>().To<ClientManagerProductCatalogView>();
            Bind<IClientManagerAddProductView>().To<ClientManagerAddProductView>();
            Bind<IClientManagerShowListOrdersView>().To<ClientManagerShowListOrdersView>();

            // kernel.Bind<IClientOrder>().To<ClientOrder>();

            Bind<ICourierGetOrderView>().To<CourierGetClientOrderView>();

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
            Bind<BookerShowNotPaidClientOrdersPresenter>().ToSelf();
            Bind<BookerCheckPaymentClientOrderPresenter>().ToSelf();

            Bind<StorekeeperPresenter>().ToSelf();
            Bind<StorekeeperSearchProviderOrderPresenter>().ToSelf();
            Bind<StorekeeperSearchClientOrderPresenter>().ToSelf();

            Bind<ClientManagerPresenter>().ToSelf();
            Bind<ClientManagerAddOrderFirstStepPresenter>().ToSelf();
            Bind<ClientManagerInspectOrderPresenter>().ToSelf();
            Bind<ClientManagerAddOrderSecondStepPresenter>().ToSelf();
            Bind<ClientManagerProductCatalogPresenter>().ToSelf();
            Bind<ClientManagerShowListOrdersPresenter>().ToSelf();

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
