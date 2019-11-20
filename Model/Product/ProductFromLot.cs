

namespace Model
{
   public class ProductFromLot : Product
    {
        public LotInformation Lot { set; get; }

        public ProductFromLot() { }
    }
}
