using ProductsModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

using System.IO;

namespace ProjectRepository
{
    public class ProductRepository : IProductRepository
    {
        SqlConnection Con;

        public ProductRepository()
        {
            var configuration = GetConfiguration();
            Con = new SqlConnection(configuration.GetSection("Data").GetSection("Connectionstring").Value);

        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }


        public List<Product> getProducts()
        {
            List<Product> ProductList = new List<Product>();
            SqlCommand com = new SqlCommand("GetProducts", Con);
            Con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Product PRO = new Product();
                PRO.ProductName = Convert.ToString(dr["ProductName"]);
                //PRO.Tags = Convert.ToString(dr["Tags"]);
                PRO.ProductCategory = Convert.ToString(dr["ProductCategory"]);
                PRO.Availablestock = Convert.ToInt32(dr["Availablestock"]);
                ProductList.Add(PRO);

            }
            return ProductList;
        }

        public Product getProductsbyID(int ProductID)
        {
            //need to write
            Con.Open();
            SqlCommand com = new SqlCommand("GetProductsbyID", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductID", ProductID);
           SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Product PRO = new Product();
                
                PRO.ProductName = Convert.ToString(dr["ProductName"]);
                //PRO.Tags = Convert.ToString(dr["Tags"]);
                PRO.ProductCategory = Convert.ToString(dr["ProductCategory"]);
                PRO.Availablestock = Convert.ToInt32(dr["Availablestock"]);
               

            }
           
        }



        public int AddProduct(Product PO)
        {
            SqlCommand com = new SqlCommand("AddProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductName", PO.ProductName);
            com.Parameters.AddWithValue("@Tags", PO.Tags);
            com.Parameters.AddWithValue("@ProductCategory", PO.ProductCategory);
            com.Parameters.AddWithValue("@AvailableStock", PO.Availablestock);
            Con.Open();
            return com.ExecuteNonQuery(); 

        }
        public int DeleteProduct(int ProductID)
        {
            SqlCommand com = new SqlCommand("DeleteProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductID", ProductID);
            Con.Open();
            return com.ExecuteNonQuery();
        }

        public int UpdateProduct(Product PO)

        {
            SqlCommand com = new SqlCommand("UpdateProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductID", PO.ProductID);
            com.Parameters.AddWithValue("@ProductName", PO.ProductName);
            com.Parameters.AddWithValue("@Tags", PO.Tags);
            com.Parameters.AddWithValue("@ProductCategory", PO.ProductCategory);
            com.Parameters.AddWithValue("@AvailableStock", PO.Availablestock);
            Con.Open();
            return com.ExecuteNonQuery();
        }
    }
}
