namespace Model
{
    public interface IServiceForFilingClientOrder
    {
        void AddProduct(ProductFromLot prod);
        void RemoveProduct(int prodId);
        void InitializeOrder();
        void AddClientInfo(ClientInformation info);
        ClientOrder GetClientOrder();
    }
}
