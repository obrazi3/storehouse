namespace Model
{
    public interface IBankForDeliveryOrderService
    {
        bool PayDeliveryFromProvider(int bankIdProvider, int sum);
    }
}
