namespace Model
{
    class BriefInvoiceInfo : IBriefInvoiceInfo
    {
        private string _name;
        private string _number;
        private string _cost;

        public BriefInvoiceInfo() : this(null, null, null) { }
        public BriefInvoiceInfo(string name, string number, string cost)
        {
            SetName(name);
            SetNumber(number);
            SetCost(cost);
        }

        public string GetCost()
        {
            return _cost;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetNumber()
        {
            return _number;
        }

        public void SetCost(string cost)
        {

            _cost = string.Copy(cost);
        }

        public void SetName(string name)
        {
            _name = string.Copy(name);
        }

        public void SetNumber(string number)
        {
            _number = string.Copy(number);
        }
    }
}
