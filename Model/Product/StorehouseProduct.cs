using System;
using System.Collections.Generic;

namespace Model
{
    public class StorehouseProduct : Product, IComparable
    {
        public int TotalQuantityProduct { private set; get; }

        private List<LotInformation> listLotInformation;
        private ProductCharacteristic characteristic;

        public StorehouseProduct()
        {

            listLotInformation = new List<LotInformation>();
        }

        public StorehouseProduct(ProductFromLot prod) : base()
        {
            ProductCategory = (string)prod.ProductCategory.Clone();
            ProduceCountry = (string)prod.ProduceCountry.Clone();
            ProductGroup = (string)prod.ProductGroup.Clone();
            ProductName = (string)prod.ProductName.Clone();
            AddLot(prod.Lot);
            Measure = (Measure)prod.Measure.Clone();
            Price = prod.Price;
        }

        public void AddLot(LotInformation info)
        {
            TotalQuantityProduct += info.QuantityProduct;
            UpdateProductCharacteristic();
            foreach (LotInformation inf in listLotInformation)
            {
                if (inf.EqualsProductionDate(info))
                {
                    inf.QuantityProduct += info.QuantityProduct;
                    return;
                }
            }

            listLotInformation.Add(info);
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
            UpdateProductCharacteristic();
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
            product.ProductId = this.ProductId;
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
            UpdateProductCharacteristic();
            return characteristic;
        }

        public int CompareTo(object obj)
        {
            return this.ProductName.CompareTo(((StorehouseProduct)obj).ProductName);
        }

        private void UpdateProductCharacteristic()
        {
            if (characteristic == null)
            {
                characteristic = new ProductCharacteristic();
                characteristic.Measure = (Measure)this.Measure.Clone();
                characteristic.Price = this.Price;
                characteristic.ProductId = this.ProductId;
                characteristic.ProductName = (string)this.ProductName.Clone();
            }
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
