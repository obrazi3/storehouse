using System;
using System.Collections.Generic;
using System.Globalization;

namespace Model
{
    public class ClientOrder : ICloneable
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        private List<ProductFromLot> listClientProduct;
        public ClientInformation ClientInfo { get; set; }
        public StatusClientOrder Status { get; set; }
        public int TotalCost { get; set; }

        public ClientOrder()
        {
            listClientProduct = new List<ProductFromLot>();
            ClientInfo = new ClientInformation();
        }

        public void AddProduct(ProductFromLot prod)
        {
            listClientProduct.Add(prod);
        }

        public void RemoveProduct(ProductFromLot prod)
        {
            listClientProduct.Remove(prod);
        }

        public bool Equals(ClientOrder order)
        {
            return OrderId.Equals(order.OrderId);
        }


        public object Clone()
        {
            ClientOrder order = new ClientOrder();
            order.OrderId = this.OrderId;
            order.OrderDate = this.OrderDate;
            order.listClientProduct = CloneProductList();
            order.ClientInfo = (ClientInformation)this.ClientInfo.Clone();
            order.Status = this.Status;
            order.TotalCost = this.TotalCost;

            return order;
        }

        public List<ProductFromLot> GetProductList()
        {
            return CloneProductList();
        }


        internal List<ProductFromLot> GetListProducts()
        {
            return listClientProduct;
        }

        private List<ProductFromLot> CloneProductList()
        {
            List<ProductFromLot> products = new List<ProductFromLot>();
            foreach (var prod in listClientProduct)
            {
                products.Add((ProductFromLot)prod.Clone());
            }

            return products;
        }
    }

    public enum StatusClientOrder
    {
        NotPaid, Paid, GiveOut, OnDelivery
    }
}
