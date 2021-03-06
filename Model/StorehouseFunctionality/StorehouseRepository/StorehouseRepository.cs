﻿using System.Collections.Generic;
using Ninject;

namespace Model
{
    public class StorehouseRepository : IStorehouseRepository
    {
        private readonly IKernel _kernel;
        private SortedDictionary<string, SortedDictionary<string, List<StorehouseProduct>>> _productStorage;
        private SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> _productCatalog;

        public StorehouseRepository(IKernel kernel)
        {
            this._kernel = kernel;
            _productStorage = new SortedDictionary<string, SortedDictionary<string, List<StorehouseProduct>>>();
            _productCatalog = new SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>>();
        }

        public void AddProductFromLot(ProductFromLot prod)
        {
            var dictCategory = _productStorage[prod.ProductCategory];
            var listProducts = dictCategory[prod.ProductGroup];
            foreach (StorehouseProduct pr in listProducts)
            {
                if (pr.ProductName.Equals(prod.ProductName) && pr.Price.Equals(prod.Price) &&
                    pr.Measure.Equals(prod.Measure))
                {
                    IServiceForStorehouseProduct service = _kernel.Get<IServiceForStorehouseProduct>();
                    service.SetStorehouseProduct(pr);
                    service.AddLot(prod.Lot);
                    service.UpdateProductCharacteristic();
                    break;
                }
            }
        }

        public void AddStoreHouseProduct(StorehouseProduct prod)
        {
            SortedDictionary<string, List<StorehouseProduct>> dictGroups;
            List<StorehouseProduct> listProducts;

            if (GetGroupsFromCategory(prod.ProductCategory) == null)
            {
                listProducts = new List<StorehouseProduct>();
                listProducts.Add(prod);
                dictGroups = new SortedDictionary<string, List<StorehouseProduct>>();
                dictGroups.Add(prod.ProductGroup, listProducts);
                _productStorage.Add(prod.ProductCategory, dictGroups);
            }
            else
            {
                dictGroups = GetGroupsFromCategory(prod.ProductCategory);
                if (GetListProductsFromGroup(dictGroups, prod.ProductGroup) == null)
                {
                    listProducts = new List<StorehouseProduct>();
                    listProducts.Add(prod);
                    dictGroups.Add(prod.ProductGroup, listProducts);
                }
                else
                {
                    listProducts = GetListProductsFromGroup(dictGroups, prod.ProductGroup);
                    listProducts.Add(prod);
                }
            }

            AddProductInCatalog(prod);
        }


        //Проверка на наличие наименования продукта на складе. В случае, если наименование отсутствует на складе, Сервису необходимо создать новый StorehouseProduct
        //и добавить его в хранилище.
        public bool ContainsProduct(ProductFromLot prod)
        {
            if (_productStorage.ContainsKey(prod.ProductCategory))
            {
                SortedDictionary<string, List<StorehouseProduct>> dictCategory = _productStorage[prod.ProductCategory];
                if (dictCategory.ContainsKey(prod.ProductGroup))
                {
                    List<StorehouseProduct> listProducts = dictCategory[prod.ProductGroup];
                    foreach (StorehouseProduct pr in listProducts)
                    {
                        if (pr.ProductName.Equals(prod.ProductName) && pr.Price.Equals(prod.Price) &&
                            pr.Measure.Equals(prod.Measure))
                        {
                            return true;
                        }
                    }

                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public ProductFromLot GetProduct(int productId, int numberOfProduct)
        {
            StorehouseProduct baseProd = FindStorehouseProductById(productId);
            IServiceForStorehouseProduct service = _kernel.Get<IServiceForStorehouseProduct>();
            service.SetStorehouseProduct(baseProd);
            ProductFromLot prod = service.GetProductFromLot(numberOfProduct);
            service.UpdateProductCharacteristic();
            return prod;
        }

        public SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProductCatalog()
        {
            var cloneCatalog = new SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>>();
            foreach (var categoryPair in _productCatalog)
            {
                var cloneCategory = categoryPair.Key;
                cloneCatalog.Add(cloneCategory, new SortedDictionary<string, List<ProductCharacteristic>>());
                foreach (var groupPair in categoryPair.Value)
                {
                    var cloneGroup = cloneCatalog[cloneCategory];
                    var cloneListCharact = new List<ProductCharacteristic>();
                    cloneGroup.Add(groupPair.Key, cloneListCharact);
                    foreach (var prod in groupPair.Value)
                    {
                        if (prod.TotalQuantityProduct != 0)
                        {
                            var cloneProd = (ProductCharacteristic)prod.Clone();
                            cloneListCharact.Add(cloneProd);
                        }
                    }
                }
            }

            return cloneCatalog;
        }

        public List<StorehouseProduct> GetListAllProducts()
        {
            List<StorehouseProduct> clone = new List<StorehouseProduct>();
            foreach (var categoryPair in _productStorage)
            {
                foreach (var groupPair in categoryPair.Value)
                {
                    foreach (var prod in groupPair.Value)
                    {
                        clone.Add((StorehouseProduct)prod.Clone());
                    }
                }
            }

            return clone;
        }

        private SortedDictionary<string, List<StorehouseProduct>> GetGroupsFromCategory(string category)
        {
            if (_productStorage.ContainsKey(category))
                return _productStorage[category];
            return null;
        }

        private List<StorehouseProduct> GetListProductsFromGroup(
            SortedDictionary<string, List<StorehouseProduct>> category, string group)
        {
            if (category.ContainsKey(group))
                return category[group];
            return null;
        }

        private StorehouseProduct FindStorehouseProductById(int productId)
        {
            foreach (string keyCategory in _productStorage.Keys)
            {
                var prodCategory = _productStorage[keyCategory];
                foreach (string keyGroup in prodCategory.Keys)
                {
                    var prodGroup = prodCategory[keyGroup];
                    foreach (StorehouseProduct prod in prodGroup)
                    {
                        if (prod.ProductId == productId)
                            return prod;
                    }
                }
            }

            return null;
        }

        private SortedDictionary<string, List<ProductCharacteristic>> GetCatalogGroupsFromCategory(string category)
        {
            if (_productCatalog.ContainsKey(category))
                return _productCatalog[category];
            return null;
        }

        private List<ProductCharacteristic> GetCatalogListProductsFromGroup(
            SortedDictionary<string, List<ProductCharacteristic>> category, string group)
        {
            if (category.ContainsKey(group))
                return category[group];
            return null;
        }

        private void AddProductInCatalog(StorehouseProduct prod)
        {
            SortedDictionary<string, List<ProductCharacteristic>> dictGroups;
            List<ProductCharacteristic> listCharacteristics;

            if (GetCatalogGroupsFromCategory(prod.ProductCategory) == null)
            {
                listCharacteristics = new List<ProductCharacteristic>();
                listCharacteristics.Add(prod.GetProductCharacteristic());
                dictGroups = new SortedDictionary<string, List<ProductCharacteristic>>();
                dictGroups.Add(prod.ProductGroup, listCharacteristics);
                _productCatalog.Add(prod.ProductCategory, dictGroups);
            }
            else
            {
                dictGroups = GetCatalogGroupsFromCategory(prod.ProductCategory);
                if (GetCatalogListProductsFromGroup(dictGroups, prod.ProductGroup) == null)
                {
                    listCharacteristics = new List<ProductCharacteristic>();
                    listCharacteristics.Add(prod.GetProductCharacteristic());
                    dictGroups.Add(prod.ProductGroup, listCharacteristics);
                }
                else
                {
                    listCharacteristics = GetCatalogListProductsFromGroup(dictGroups, prod.ProductGroup);
                    listCharacteristics.Add(prod.GetProductCharacteristic());
                }
            }
        }
    }
}
