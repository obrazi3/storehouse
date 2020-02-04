using System;

namespace Model
{
    public class Model : IModel
    {
        public IBriefInvoiceInfo FindIncomingInvoice(int number)
        {
            BriefInvoiceInfo info = new BriefInvoiceInfo("Павел", "1234", "50 рублей");
            return info;
        }

        public IBriefInvoiceInfo FindSalesInvoice(int number)
        {
            throw new NotImplementedException();
        }
    }
}
