using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductProvider : IComparable
    {
        public string Name { get; set; }
        public string BankAccountNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int ProviderId { get; set; }
        private List<string> productCategories;

        public ProductProvider()
        {
            productCategories = new List<string>();
        }

        public void AddProductCategory(string category)
        {
            productCategories.Add(category);
            productCategories.Sort();
        }

        public void RemoveProductCategory(string category)
        {
            productCategories.Remove(category);
        }

        public int CompareTo(object obj)
        {
            int lenListCategories2 = ((ProductProvider)obj).productCategories.Count;
            int minLenListCategories = (lenListCategories2 > productCategories.Count) ? productCategories.Count : lenListCategories2;
            for (int i = 0; i < minLenListCategories; i++)
            {
                int resCompare = productCategories[i].CompareTo(((ProductProvider)obj).productCategories[0]);
                if (resCompare != 0)
                    return resCompare;
            }

            return 0;
        }
    }
}
