﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductProviderOrder : ICloneable
    {
        public ProductProvider Provider { get; set; }
        public int OrderId { get; set; }
        public int TotalSumOrder { get; private set; }
        public StatusProviderOrder Status { get; set; }
        public DateTime OrderDate { get; set; }
        private List<ProductFromLot> listProducts;

        public ProductProviderOrder()
        {
            listProducts = new List<ProductFromLot>();
        }

        public void AddProduct(ProductFromLot prod)
        {
            listProducts.Add(prod);
            TotalSumOrder += (prod.Price * prod.Lot.QuantityProduct);
        }

        public void RemoveProduct(ProductFromLot prod)
        {
            if (listProducts.Remove(prod))
                TotalSumOrder -= (prod.Price * prod.Lot.QuantityProduct);
        }

        public object Clone()
        {
            ProductProviderOrder clone = new ProductProviderOrder();
            clone.Provider = (ProductProvider)this.Provider.Clone();
            clone.OrderId = this.OrderId;
            clone.TotalSumOrder = this.TotalSumOrder;
            clone.Status = this.Status;
            clone.OrderDate = this.OrderDate;

            List<ProductFromLot> clonelistProducts = new List<ProductFromLot>();
            foreach (var prod in listProducts)
            {
                clonelistProducts.Add((ProductFromLot)prod.Clone());
            }

            return clone;
        }
    }

    public enum StatusProviderOrder
    { NotPaid, Paid, Received }
}
