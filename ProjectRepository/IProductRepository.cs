using ProductsModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRepository
{
    public interface IProductRepository
    {

         public List<Product> getProducts();
       public Product getProductsbyID(int ProductID);
        public int AddProduct(Product PO);
        public int DeleteProduct(int ProductID);
        public int UpdateProduct(Product PO);
    }
}
