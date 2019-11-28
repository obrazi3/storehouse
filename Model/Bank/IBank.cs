namespace Model
{
    public interface IBank
    {
        bool CheckPaymentByClient(int orderId);
        bool PayDeliveryFromProvider(int bankIdProvider, int sum);
    }
}
