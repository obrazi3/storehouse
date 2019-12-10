using System;
using System.Collections.Generic;

namespace Model
{
    public class ClientOrder : ICloneable
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        private List<ProductFromLot> _listClientProduct;
        public ClientInformation ClientInfo { get; set; }
        public StatusClientOrder Status { get; set; }
        public int TotalCost { get; set; }
        public bool IsDelivery;

        public ClientOrder()
        {
            _listClientProduct = new List<ProductFromLot>();
            ClientInfo = new ClientInformation();
            OrderId = -1;
        }

        public void AddProduct(ProductFromLot prod)
        {
            _listClientProduct.Add(prod);
        }

        public void RemoveProduct(ProductFromLot prod)
        {
            _listClientProduct.Remove(prod);
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
            order._listClientProduct = CloneProductList();
            order.ClientInfo = (ClientInformation)this.ClientInfo.Clone();
            order.Status = this.Status;
            order.TotalCost = this.TotalCost;
            order.IsDelivery = this.IsDelivery;

            return order;
        }

        public List<ProductFromLot> GetCloneProductList()
        {
            return CloneProductList();
        }


        internal List<ProductFromLot> GetListProducts()
        {
            return _listClientProduct;
        }

        private List<ProductFromLot> CloneProductList()
        {
            List<ProductFromLot> products = new List<ProductFromLot>();
            foreach (var prod in _listClientProduct)
            {
                products.Add((ProductFromLot)prod.Clone());
            }

            return products;
        }
    }

    public enum StatusClientOrder
    {
        NotPaid, Paid, PaidForDelivery, GiveOut, OnDelivery
    }
}
