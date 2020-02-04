namespace Model
{
    public interface IClientOrderServiceForStorekeeper
    {
        ClientOrder GetGiveOutClientOrder(int orderId);
        bool ConfirmGiveOutClientOrder(int orderId);
        

    }
}
