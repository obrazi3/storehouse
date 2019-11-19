using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ProductProvider
    {
        public string Name { get; set; }
        public string BankAccountNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        private List<string> productCategories;

        public ProductProvider()
        {
            productCategories = new List<string>();
        }

        public void AddProductCategory(string category)
        {
            productCategories.Add(category);
        }
        
        public void RemoveProductCategory(string category)
        {
            productCategories.Remove(category);
        }
    }
}
