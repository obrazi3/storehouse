using Ninject.Modules;
using Model;
using Presenter;
using System.Windows.Forms;
using Presenter.PurcpManager.PurcpManagerAddProvider;

namespace View
{
    public class NinjectConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<IProviderOrderRepository>().To<ProviderOrderRepository>().InSingletonScope();
            Bind<IProductProviderRepository>().To<ProductProviderRepository>().InSingletonScope();
            Bind<IStorehouseRepository>().To<StorehouseRepository>().InSingletonScope();
            Bind<IStorehouseServiceForDeliveryOrderService>().To<StorehouseService>().InSingletonScope();
            Bind<IStorehouseServiceForClientOrderService>().To<StorehouseService>().InSingletonScope();
            Bind<IDeliveryOrderServiceForBooker>().To<DeliveryOrderService>().InSingletonScope();
            Bind<IDeliveryOrderServiceForStorekeeper>().To<DeliveryOrderService>().InSingletonScope();
            Bind<IDeliveryOrderServiceForPurcpManager>().To<DeliveryOrderService>().InSingletonScope();
            Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            Bind<ISignInView>().To<SignInView>();
            Bind<IClientManagerView>().To<ClientManagerView>();
            Bind<IPurcpManagerView>().To<PurcpManagerView>();
            Bind<IBookerView>().To<BookerView>();
            Bind<ICourierView>().To<CourierView>();
            Bind<IStorekeeperView>().To<StorekeeperView>();
            Bind<IStorekeeperSearchIncomingInvoiceView>().To<StorekeeperSearchIncomingInvoiceView>();
            Bind<IStorekeeperSearchSalesInvoiceView>().To<StorekeeperSearchSalesInvoiceView>();
            Bind<IClientManagerAddOrderView>().To<ClientManagerAddOrderView>();
            Bind<IClientManagerAddOrderSecondStepView>().To<ClientManagerAddOrderSecondStepView>();
            Bind<IModel>().To<Model.Model>();
            // kernel.Bind<IClientOrder>().To<ClientOrder>();
            Bind<IClientManagerInspectOrderView>().To<ClientManagerInspectOrderView>();
            Bind<ICourierGetOrderView>().To<CourierGetOrderView>();
            Bind<IPurcpManagerAddProviderView>().To<PurcpManagerAddProviderView>();
            Bind<IPurcpManagerRemoveProviderView>().To<IPurcpManagerRemoveProviderView>();
            Bind<IPurcpManagerInfoProviderView>().To<PurcpManagerInfoProviderView>();

            Bind<CourierPresenter>().ToSelf();
            Bind<BookerPresenter>().ToSelf();
            Bind<PurcpManagerPresenter>().ToSelf();
            Bind<SignInPresenter>().ToSelf();
            Bind<ClientManagerPresenter>().ToSelf();
            Bind<StorekeeperPresenter>().ToSelf();
            Bind<StorekeeperSeacrhIncomingInvoicePresenter>().ToSelf();
            Bind<StorekeeperSearchSalesInvoicePresenter>().ToSelf();
            Bind<ClientManagerAddOrderPresenter>().ToSelf();
            Bind<ClientManagerInspectOrderPresenter>().ToSelf();
            Bind<CourierGetOrderPresenter>().ToSelf();
            Bind<PurcpManagerAddProviderPresenter>().ToSelf();
            Bind<PurcpManagerRemoveProviderPresenter>().ToSelf();
            Bind<PurcpManagerInfoProviderPresenter>().ToSelf();
        }
    }
}
