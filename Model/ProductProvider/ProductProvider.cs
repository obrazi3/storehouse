using System;
using System.Collections.Generic;

namespace Model
{
    public class ProductProvider : IComparable, ICloneable
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

        public object Clone()
        {
            var clone = new ProductProvider();
            clone.Name = (string)this.Name.Clone();
            clone.BankAccountNumber = (string)this.BankAccountNumber.Clone();
            clone.ContactNumber = (string)this.ContactNumber.Clone();
            clone.Email = (string)this.Email.Clone();
            clone.ProviderId = this.ProviderId;
            clone.productCategories = new List<string>(this.productCategories.ToArray());
            return clone;
        }

        public List<string> GetListProductCategories()
        {
            List<string> copy = new List<string>();
            foreach(var category in productCategories)
            {
                copy.Add((string)category.Clone());
            }

            return copy;
        }
    }
}
