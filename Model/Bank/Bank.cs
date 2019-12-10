namespace Model
{
    public class Bank : IBankForClientOrderService, IBankForDeliveryOrderService
    {
        private int _digit;

        public bool CheckPaymentByClient(int orderId)
        {
            _digit++;
            if (_digit % 2 == 0)
                return true;
            return false;
        }

        public bool PayDeliveryFromProvider(int bankIdProvider, int sum)
        {
            _digit++;
            if (_digit % 2 != 0)
                return true;
            return false;
        }
    }
}
