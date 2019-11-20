using System;

namespace Model
{
   public class LotInformation : IComparable, ICloneable
    {
        public DateTime ProductionDate { set; get; }
        public int QuantityProduct { set; get; }

        public LotInformation() { }
        public LotInformation(DateTime date, int quantity)
        {
            ProductionDate = date;
            QuantityProduct = quantity;
        }

        public object Clone()
        {
            return new LotInformation(ProductionDate, QuantityProduct);
        }

        //Increment, Decriment
        public int CompareTo(object obj)
        {
            return -ProductionDate.CompareTo(((LotInformation)obj).ProductionDate);
        }

        public bool Equals(LotInformation lot)
        {
            return (ProductionDate.Equals(lot.ProductionDate) && QuantityProduct == lot.QuantityProduct);
        }

        public bool EqualsProductionDate(LotInformation info)
        {
            return ProductionDate.Equals(info.ProductionDate);
        }
    }
}
