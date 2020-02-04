using System.Collections.Generic;

namespace Model
{
    class ComparerProductProviderForSelectionByStatus : IComparer<ProductProviderOrder>
    {
        public int Compare(ProductProviderOrder x, ProductProviderOrder y)
        {
            return x.Status.CompareTo(y.Status);
        }
    }
}
