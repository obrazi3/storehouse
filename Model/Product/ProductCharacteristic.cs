
using System;

namespace Model
{
    public class ProductCharacteristic : ICloneable
    {
        public string ProductName { get; internal set; }
        public Measure Measure { get; internal set; }
        public int ProductId { get; internal set; }
        public int Price { get; internal set; }
        public int TotalQuantityProduct { get; internal set; }

        public ProductCharacteristic() { }

        public object Clone()
        {
            ProductCharacteristic clone = new ProductCharacteristic();
            clone.ProductName = (string)this.ProductName.Clone();
            clone.Measure = (Measure)this.Measure.Clone();
            clone.ProductId = this.ProductId;
            clone.Price = this.Price;
            clone.TotalQuantityProduct = this.TotalQuantityProduct;
            return clone;
        }
    }
}
