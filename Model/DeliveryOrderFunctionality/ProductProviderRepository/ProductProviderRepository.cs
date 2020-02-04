using System.Collections.Generic;

namespace Model
{
    public class ProductProviderRepository : IProductProviderRepository
    {
        private List<ProductProvider> _providers;

        public ProductProviderRepository()
        {
            _providers = new List<ProductProvider>();
        }

        public void AddProductProvider(ProductProvider prov)
        {
            _providers.Add(prov);
            _providers.Sort();
        }

        public List<ProductProvider> GetListProductProviders()
        {
            List<ProductProvider> clone = new List<ProductProvider>();
            foreach(var provider in _providers)
            {
                clone.Add((ProductProvider)provider.Clone());
            }

            return clone;
        }

        public ProductProvider GetProductProvider(int providerId)
        {
            foreach (var provider in _providers)
            {
                if (provider.ProviderId == providerId)
                    return (ProductProvider)provider.Clone();
            }

            return null;
        }

        public void RemoveProductProvider(int providerId)
        {
            foreach (var provider in _providers)
            {
                if (provider.ProviderId == providerId)
                {
                    _providers.Remove(provider);
                    break;
                }
            }
        }
    }
}
