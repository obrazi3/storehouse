using System.Collections.Generic;


namespace Model
{
    public interface IProductProvidersRepository
    {
        void AddProductProvider(ProductProvider prov);
        ProductProvider GetProductProvider(int providerId);
        void RemoveProductProvider(int providerId);
        List<ProductProvider> GetListProductProviders();
    }
}
