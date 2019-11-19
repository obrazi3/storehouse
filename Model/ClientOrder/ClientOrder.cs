
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Model
{
    class ClientOrder
    {
        public int OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        private List<ProductFromLot> ListClientProduct { get; }
        public ClientInformation ClientInfo { get; set; }
        public StatusClientOrder Status { get; set; }

        public ClientOrder(int _orderId, DateTime _orderDate)
        {
            this.OrderId = _orderId;
            this.OrderDate = _orderDate;
            ListClientProduct = new List<ProductFromLot>();
        }

        public void AddProduct(ProductFromLot prod)
        {
            ListClientProduct.Add(prod);
        }

        public void RemoveProduct(ProductFromLot prod)
        {
            ListClientProduct.Remove(prod);
        }

        public bool Equals(ClientOrder order)
        {
            return OrderId.Equals(order.OrderId);
        }
    }

    enum StatusClientOrder
    {
        NotPaid, Paid, GiveOut
    }
}
