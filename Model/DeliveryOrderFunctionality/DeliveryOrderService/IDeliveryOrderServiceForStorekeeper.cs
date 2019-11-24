namespace Model
{
    public interface IDeliveryOrderServiceForStorekeeper
    {
        ProductProviderOrder GetProviderPaidOrder(int orderId);
        void ConfirmProviderPaidOrder(int orderId);
    }
}
