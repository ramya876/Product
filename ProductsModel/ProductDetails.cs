using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsModel
{
    class ProductDetails
    {
        public int ProductID { get; set; }

        public int BatchNumber { get; set; }

        public int ProductDetailID { get; set; }

        public int Quantity { get; set; }

        public DateTime ProductExpiryDate { get; set; }
    }
}
