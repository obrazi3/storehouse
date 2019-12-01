namespace Model
{
    public interface IClientOrderServiceForCourier
    {
        ClientOrder GetForDeliveryClientOrder();
        bool ConfirmDelivery(int orderId);
        bool CancelDelivery(int orderId);
    }
}
