namespace Model
{
    public class Bank : IBank
    {
        private int digit;

        public bool CheckPaymentByClient(int orderId)
        {
            digit++;
            if (digit % 2 == 0)
                return true;
            return false;
        }

        public bool PayDeliveryFromProvider(int bankIdProvider, int sum)
        {
            digit++;
            if (digit % 2 != 0)
                return true;
            return false;
        }
    }
}
