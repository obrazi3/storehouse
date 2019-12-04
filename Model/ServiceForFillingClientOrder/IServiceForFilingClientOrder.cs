namespace Model
{
    public interface IServiceForFilingClientOrder
    {
        bool AddProduct(int productId, int numberOfProduct);
        bool RemoveProduct(int prodId);
        bool InitializeOrder();
        bool AddClientInfo(ClientInformation info);
        ClientOrder GetClientOrder();
        bool SetClientOrder(ClientOrder order);

    }
}
