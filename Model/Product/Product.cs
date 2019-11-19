﻿
namespace Model
{
    abstract class Product
    {
        public string ProductCategory { set; get; }
        public string ProductGroup { set; get; }
        public string ProductName { set; get; }
        public Measure Measure { set; get; }
        public int ExpirationDate { set; get; }
        public int Price { set; get; }
        public string ProduceCountry { set; get; }
        public string ProductId { set; get; }

        public Product() { }

        public bool Equals(Product prod)
        {
            return (ProductCategory.Equals(prod.ProductCategory) && ProductGroup.Equals(prod.ProductGroup)
                && ProductName.Equals(prod.ProductName));
        }
    }
}
