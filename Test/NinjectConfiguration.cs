using Ninject.Modules;
using Model;

namespace Test
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
        }
    }
}
