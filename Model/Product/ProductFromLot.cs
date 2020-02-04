namespace Model
{
    public class ProductFromLot : Product
    {
        public LotInformation Lot { private set; get; }

        public ProductFromLot()
        {
            Lot = new LotInformation();
        }

        public override object Clone()
        {
            ProductFromLot clone = new ProductFromLot();
            clone.ExpirationDate = this.ExpirationDate;
            clone.Measure = (Measure)this.Measure.Clone();
            clone.Price = this.Price;
            clone.ProduceCountry = (string)this.ProduceCountry.Clone();
            clone.ProductCategory = (string)this.ProductCategory.Clone();
            clone.ProductGroup = (string)this.ProductGroup.Clone();
            clone.ProductId = this.ProductId;
            clone.ProductName = (string)this.ProductName.Clone();
            clone.Lot = (LotInformation)this.Lot.Clone();

            return clone;
        }
    }
}
