namespace Model
{
    public interface IModel
    {
        IBriefInvoiceInfo findIncomingInvoice(int number);
        IBriefInvoiceInfo findSalesInvoice(int number);
    }
}
