

namespace Model
{
    class ProductFromLot : Product
    {
        public LotInformation Lot { set; get; }

        public ProductFromLot() { }
    }
}
