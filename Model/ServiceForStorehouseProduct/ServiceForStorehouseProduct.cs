using System;
using System.Collections.Generic;

namespace Model
{
    public class ServiceForStorehouseProduct : IServiceForStorehouseProduct
    {
        private StorehouseProduct _product;


        public void SetStorehouseProduct(StorehouseProduct product)
        {
            if (product != null)
                this._product = product;
            else
                throw new NullReferenceException();
        }

        public void AddLot(LotInformation info)
        {
            _product.TotalQuantityProduct += info.QuantityProduct;
            UpdateProductCharacteristic();
            var listLotInfo = _product.GetListLotInformation();
            foreach (LotInformation inf in listLotInfo)
            {
                if (inf.EqualsProductionDate(info))
                {
                    inf.QuantityProduct += info.QuantityProduct;
                    return;
                }
            }

            listLotInfo.Add(info);
        }

        public void RemoveLot(LotInformation info)
        {
            var listLotInformation = _product.GetListLotInformation();
            foreach (LotInformation lot in listLotInformation)
            {
                if (lot.Equals(info))
                {
                    _product.TotalQuantityProduct -= lot.QuantityProduct;
                    listLotInformation.Remove(lot);
                    break;
                }
            }
        }

        public ProductFromLot GetProductFromLot(int number)
        {
            _product.TotalQuantityProduct -= number;

            ProductFromLot productFromLot = new ProductFromLot();

            productFromLot.ProductName = (string)_product.ProductName.Clone();
            productFromLot.ProduceCountry = (string)_product.ProduceCountry.Clone();
            productFromLot.ProductGroup = (string)_product.ProductGroup.Clone();
            productFromLot.Price = _product.Price;
            productFromLot.ProductCategory = (string)_product.ProductCategory.Clone();
            productFromLot.ProductId = _product.ProductId;
            productFromLot.Measure = (Measure)_product.Measure.Clone();
            productFromLot.ExpirationDate = _product.ExpirationDate;

            DateTime oldestProduct = new DateTime(1, 1, 1);
            LotInformation clientLot = new LotInformation();

            List<LotInformation> lotsForRemove = new List<LotInformation>();
            var listLotInformation = _product.GetListLotInformation();
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

            productFromLot.Lot.ProductionDate = clientLot.ProductionDate;
            productFromLot.Lot.QuantityProduct = clientLot.QuantityProduct;

            foreach (var lot in lotsForRemove)
            {
                listLotInformation.Remove(lot);
            }

            return productFromLot;
        }

        public void UpdateProductCharacteristic()
        {
            ProductCharacteristic characteristic;
            if (_product.GetProductCharacteristic() == null)
            {
                characteristic = new ProductCharacteristic();
                characteristic.Measure = (Measure)_product.Measure.Clone();
                characteristic.Price = _product.Price;
                characteristic.ProductId = _product.ProductId;
                characteristic.ProductName = (string)_product.ProductName.Clone();
                characteristic.ProduceCountry = (string)_product.ProduceCountry.Clone();
                characteristic.ProductCategory = (string)_product.ProductCategory.Clone();
                characteristic.ProductGroup = (string)_product.ProductGroup.Clone();
                _product.SetProductCharacteristic(characteristic);
            }
            else
                characteristic = _product.GetProductCharacteristic();
            
            characteristic.TotalQuantityProduct = _product.TotalQuantityProduct;

            
        }
    }
}
