using System.Collections.Generic;

namespace Model
{
    public class ProductProviderRepository : IProductProviderRepository
    {
        private List<ProductProvider> providers;

        public ProductProviderRepository()
        {
            providers = new List<ProductProvider>();
        }

        public void AddProductProvider(ProductProvider prov)
        {
            providers.Add(prov);
            providers.Sort();
        }

        public List<ProductProvider> GetListProductProviders()
        {
            return providers;
        }

        public ProductProvider GetProductProvider(int providerId)
        {
            foreach (var provider in providers)
            {
                if (provider.ProviderId == providerId)
                    return (ProductProvider)provider.Clone();
            }

            return null;
        }

        public void RemoveProductProvider(int providerId)
        {
            foreach (var provider in providers)
            {
                if (provider.ProviderId == providerId)
                {
                    providers.Remove(providers[providerId]);
                    break;
                }
            }
        }
    }
}
