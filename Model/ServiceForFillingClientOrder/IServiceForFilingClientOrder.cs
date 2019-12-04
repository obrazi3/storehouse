namespace Model
{
    public interface IServiceForFilingClientOrder
    {
        bool AddProduct(ProductFromLot prod);
        bool RemoveProduct(int prodId);
        bool InitializeOrder();
        bool AddClientInfo(ClientInformation info);
        ClientOrder GetClientOrder();
        bool SetClientOrder(ClientOrder order);
    }
}
