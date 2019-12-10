using System;
using System.Collections.Generic;

namespace Model
{
    public class StorehouseProduct : Product, IComparable
    {
        public int TotalQuantityProduct { internal set; get; }

        private List<LotInformation> _listLotInformation;
        private ProductCharacteristic _characteristic;

        public StorehouseProduct()
        {
            _listLotInformation = new List<LotInformation>();
        }

        public StorehouseProduct(ProductFromLot prod) : this()
        {
            ProductCategory = (string)prod.ProductCategory.Clone();
            ProduceCountry = (string)prod.ProduceCountry.Clone();
            ProductGroup = (string)prod.ProductGroup.Clone();
            ProductName = (string)prod.ProductName.Clone();
            TotalQuantityProduct += prod.Lot.QuantityProduct;
            _listLotInformation.Add(prod.Lot);
            Measure = (Measure)prod.Measure.Clone();
            Price = prod.Price;
        }

        /* public void AddLot(LotInformation info)
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
         }*/

        /*  public void RemoveLot(LotInformation info)
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
          }*/

        /*  public ProductFromLot GetProductFromLot(int number)
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
  
              DateTime oldestProduct = new DateTime(1, 1, 1);
              LotInformation clientLot = new LotInformation();
  
              List<LotInformation> lotsForRemove = new List<LotInformation>();
              foreach (LotInformation lot in listLotInformation)
              {
                  if (lot.QuantityProduct >= number)
                  {
                      clientLot.QuantityProduct += number;
                      if (oldestProduct.Equals(new DateTime(1, 1, 1)))
                          clientLot.ProductionDate = lot.ProductionDate;
                      if (lot.QuantityProduct == number)
                          lotsForRemove.Add(lot);
                      lot.QuantityProduct -= number;
                      break;
                  }
                  else
                  {
                      clientLot.QuantityProduct += lot.QuantityProduct;
                      number -= lot.QuantityProduct;
                      if (oldestProduct.Equals(new DateTime(1, 1, 1)))
                      {
                          clientLot.ProductionDate = lot.ProductionDate;
                          oldestProduct = lot.ProductionDate;
                      }
  
                      lotsForRemove.Add(lot);
                  }
              }
  
              product.Lot.ProductionDate = clientLot.ProductionDate;
              product.Lot.QuantityProduct = clientLot.QuantityProduct;
              UpdateProductCharacteristic();
              RemoveEmptyLots(lotsForRemove);
              return product;
          }*/

        public List<LotInformation> GetCloneListLotInformation()
        {
            List<LotInformation> copyList = new List<LotInformation>();
            foreach (LotInformation lot in _listLotInformation)
            {
                copyList.Add((LotInformation)lot.Clone());
            }

            return copyList;
        }

        public ProductCharacteristic GetProductCharacteristic()
        {
            //UpdateProductCharacteristic();
            return _characteristic;
        }

        public int CompareTo(object obj)
        {
            return this.ProductName.CompareTo(((StorehouseProduct)obj).ProductName);
        }

        public override object Clone()
        {
            StorehouseProduct clone = new StorehouseProduct();
            clone.ExpirationDate = this.ExpirationDate;
            clone.Measure = (Measure)this.Measure.Clone();
            clone.Price = this.Price;
            clone.ProduceCountry = (string)this.ProduceCountry.Clone();
            clone.ProductCategory = (string)this.ProductCategory.Clone();
            clone.ProductGroup = (string)this.ProductGroup.Clone();
            clone.ProductId = this.ProductId;
            clone.ProductName = (string)this.ProductName.Clone();
            clone.TotalQuantityProduct = this.TotalQuantityProduct;
            clone._characteristic = (ProductCharacteristic)this._characteristic.Clone();

            return clone;
        }


        internal List<LotInformation> GetListLotInformation()
        {
            return _listLotInformation;
        }

        internal void SetProductCharacteristic(ProductCharacteristic characteristic)
        {
            this._characteristic = characteristic;
        }


     /*   private void UpdateProductCharacteristic()
        {
            if (characteristic == null)
            {
                characteristic = new ProductCharacteristic();
                characteristic.Measure = (Measure)this.Measure.Clone();
                characteristic.Price = this.Price;
                characteristic.ProductId = this.ProductId;
                characteristic.ProductName = (string)this.ProductName.Clone();
                characteristic.ProduceCountry = (string)this.ProduceCountry.Clone();
                characteristic.ProductCategory = (string)this.ProductCategory.Clone();
                characteristic.ProductGroup = (string)this.ProductGroup.Clone();
            }

            characteristic.TotalQuantityProduct = TotalQuantityProduct;
        }*/


     /*   private void RemoveEmptyLots(List<LotInformation> lotsForRemove)
        {
            foreach (var lot in lotsForRemove)
            {
                listLotInformation.Remove(lot);
            }
        }*/
    }
}
