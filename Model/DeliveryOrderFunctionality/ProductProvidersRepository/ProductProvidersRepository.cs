using System.Collections.Generic;

namespace Model
{
    public class ProductProvidersRepository : IProductProvidersRepository
    {
        private List<ProductProvider> providers;

        public ProductProvidersRepository() { }

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
                    return provider;
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
