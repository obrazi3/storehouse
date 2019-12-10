namespace Model
{
    public interface IServiceForFilingPersonInfoInClientOrder
    {
        bool InitializeOrder();
        bool AddClientInfo(ClientInformation info);
        ClientOrder GetClientOrder();
        bool SetClientOrder(ClientOrder order);
    }
}
