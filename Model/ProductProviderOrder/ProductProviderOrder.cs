using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ProductProviderOrder
    {
        public ProductProvider Provider { get; set; }
        public int OrderNumber { get; set; }
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
    }

    enum StatusProviderOrder
    { NotPaid, Paid, Received }
}
