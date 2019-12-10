namespace Model
{
    public interface IModel
    {
        IBriefInvoiceInfo FindIncomingInvoice(int number);
        IBriefInvoiceInfo FindSalesInvoice(int number);
    }
}
