﻿using System;

namespace Model
{
    public class ProductCharacteristic : ICloneable
    {
        public string ProductName { get; internal set; }
        public Measure Measure { get; internal set; }
        public int ProductId { get; internal set; }
        public int Price { get; internal set; }
        public int TotalQuantityProduct { get; internal set; }

        public string ProduceCountry { get; internal set; }
        public string ProductGroup { get; internal set; }
        public string ProductCategory { get; internal set; }

        public object Clone()
        {
            ProductCharacteristic clone = new ProductCharacteristic();
            clone.ProductName = (string)this.ProductName.Clone();
            clone.Measure = (Measure)this.Measure.Clone();
            clone.ProductId = this.ProductId;
            clone.Price = this.Price;
            clone.TotalQuantityProduct = this.TotalQuantityProduct;
            clone.ProduceCountry = (string)this.ProduceCountry.Clone();
            clone.ProductGroup = (string)this.ProductGroup.Clone();
            clone.ProductCategory = (string)this.ProductCategory.Clone();
            return clone;
        }
    }
}
