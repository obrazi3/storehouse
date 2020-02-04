using System.Collections.Generic;

namespace Model
{
    class ComparerProductProviderOrderForRepository : IComparer<ProductProviderOrder>
    {
        public int Compare(ProductProviderOrder x, ProductProviderOrder y)
        {
            return x.OrderId.CompareTo(y.OrderId);
        }
    }
}
