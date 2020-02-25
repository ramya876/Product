using ProductsModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProductsBO
{
   public interface IProductBO
    {
        public List<Product> getProductsBO();
        public Product getProductBO(int ProductID);
        public int AddProduct(Product PO);
        public int DeleteProduct(int ProductID);
        public int UpdateProduct(Product PO);


        }
}
