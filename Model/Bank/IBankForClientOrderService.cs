namespace Model
{
    public interface IBankForClientOrderService
    {
        bool CheckPaymentByClient(int orderId);
    }
}
