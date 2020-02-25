using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsModel
{
   public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public List<string> Tags { get; set; }
        public string  ProductCategory { get; set; }

        public int Availablestock { get; set; }

    }
}
