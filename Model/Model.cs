using System;

namespace Model
{
    public class Model : IModel
    {
        public IBriefInvoiceInfo findIncomingInvoice(int number)
        {
            BriefInvoiceInfo info = new BriefInvoiceInfo("Павел", "1234", "50 рублей");
            return info;
        }

        public IBriefInvoiceInfo findSalesInvoice(int number)
        {
            throw new NotImplementedException();
        }
    }
}
