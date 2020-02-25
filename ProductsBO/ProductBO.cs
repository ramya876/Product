using System;
using System.Collections.Generic;
using System.Text;
using ProductsModel;

namespace ProductsBO
{
   public class ProductBO: IProductBO
    {
        public List<Product> getProductsBO()


        {
            List<Product> ls = new List<Product>();
           
            Product p1 = new Product();
            p1.ProductID = 1;
            p1.ProductName = "Shirt";
            p1.ProductCategory = "Mens Wear";
            p1.Tags = new List<string> { "#menwear", "formal" };

            Product p2 = new Product();
            p2.ProductID = 2;
            p2.ProductName = "Pant";
            p2.ProductCategory = "Mens Wear";
            p2.Tags = new List<string> { "#menwear", "formal" };

            ls.Add(p1);
            ls.Add(p2);

            return ls;

        }

        public Product getProductBO(int ProductID)
        {
            return new Product();
        }

        public int AddProduct(Product PO)
        {
            return 0;
        }

        public int DeleteProduct(int ProductID)
        {
            return 0;
        }

        public int UpdateProduct(Product PO)
        {
            return 0;
        }

    }
}
