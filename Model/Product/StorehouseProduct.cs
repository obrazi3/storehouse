using System;
using System.Collections.Generic;

namespace Model
{
    class StorehouseProduct : Product, IComparable
    {
        public int TotalQuantityProduct { private set; get; }

        private List<LotInformation> listLotInformation;
        private ProductCharacteristic characteristic;

        public StorehouseProduct()
        {
            characteristic = new ProductCharacteristic();
            characteristic.Measure = (Measure)this.Measure.Clone();
            characteristic.Price = this.Price;
            characteristic.ProductId = (string)this.ProductId.Clone();
            characteristic.ProductName = (string)this.ProductName.Clone();
            characteristic.TotalQuantityProduct = this.TotalQuantityProduct;
        }

        public void AddLot(LotInformation info)
        {
            listLotInformation.Add(info);
            TotalQuantityProduct += info.QuantityProduct;
            UpdateProductCharacteristic();
        }

        public void RemoveLot(LotInformation info)
        {
            foreach (LotInformation lot in listLotInformation)
            {
                if (lot.Equals(info))
                {
                    TotalQuantityProduct -= lot.QuantityProduct;
                    listLotInformation.Remove(lot);
                    break;
                }
            }
        }

        public ProductFromLot GetProductFromLot(int number)
        {
            TotalQuantityProduct -= number;

            ProductFromLot product = new ProductFromLot();

            product.ProductName = (string)this.ProductName.Clone();
            product.ProduceCountry = (string)this.ProduceCountry.Clone();
            product.ProductGroup = (string)this.ProductGroup.Clone();
            product.Price = this.Price;
            product.ProductCategory = (string)this.ProductCategory.Clone();
            product.ProductId = (string)this.ProductId.Clone();
            product.Measure = (Measure)this.Measure.Clone();
            product.ExpirationDate = this.ExpirationDate;

            DateTime oldestProduct = new DateTime(0, 0, 0);
            LotInformation clientLot = new LotInformation();
            foreach (LotInformation lot in listLotInformation)
            {
                if (lot.QuantityProduct >= number)
                {
                    clientLot.QuantityProduct += number;
                    if (oldestProduct.Equals(new DateTime(0, 0, 0)))
                        clientLot.ProductionDate = lot.ProductionDate;
                    if (lot.QuantityProduct == number)
                        listLotInformation.Remove(lot);
                    lot.QuantityProduct -= number;
                    break;
                }
                else
                {
                    clientLot.QuantityProduct += lot.QuantityProduct;
                    number -= lot.QuantityProduct;
                    if (oldestProduct.Equals(new DateTime(0, 0, 0)))
                    {
                        clientLot.ProductionDate = lot.ProductionDate;
                        oldestProduct = lot.ProductionDate;
                    }
                    listLotInformation.Remove(lot);
                }
            }

            product.Lot = clientLot;
            UpdateProductCharacteristic();
            return product;
        }

        public List<LotInformation> GetListLotInformation()
        {
            List<LotInformation> copyList = new List<LotInformation>();
            foreach (LotInformation lot in listLotInformation)
            {
                copyList.Add((LotInformation)lot.Clone());
            }
            return copyList;

        }

        public ProductCharacteristic GetProductCharacteristic()
        {
            return characteristic;
        }

        public int CompareTo(object obj)
        {
            return this.ProductName.CompareTo(((StorehouseProduct)obj).ProductName);
        }

        private void UpdateProductCharacteristic()
        {
            characteristic.TotalQuantityProduct = TotalQuantityProduct;
        }



        /* 
         private void CountTotalQuantityProduct()
         {
             int totalQuant = 0;

             foreach (LotInformation lot in listLotInformation)
             {
                 totalQuant += lot.QuantityProduct;
             }

             TotalQuantityProduct = totalQuant;
         }
         */
    }
}
