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
        private List<string> _productCategories;

        public ProductProvider()
        {
            _productCategories = new List<string>();
        }

        public void AddProductCategory(string category)
        {
            _productCategories.Add(category);
            _productCategories.Sort();
        }

        public void RemoveProductCategory(string category)
        {
            _productCategories.Remove(category);
        }

        public int CompareTo(object obj)
        {
            int lenListCategories2 = ((ProductProvider)obj)._productCategories.Count;
            int minLenListCategories = (lenListCategories2 > _productCategories.Count) ? _productCategories.Count : lenListCategories2;
            for (int i = 0; i < minLenListCategories; i++)
            {
                int resCompare = _productCategories[i].CompareTo(((ProductProvider)obj)._productCategories[0]);
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
            clone._productCategories = new List<string>(this._productCategories.ToArray());
            return clone;
        }

        public List<string> GetListProductCategories()
        {
            List<string> copy = new List<string>();
            foreach(var category in _productCategories)
            {
                copy.Add((string)category.Clone());
            }

            return copy;
        }
    }
}
