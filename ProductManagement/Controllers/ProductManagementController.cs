using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsBO;
using ProductsModel;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManagementController : ControllerBase
    {
        public readonly IProductBO _productBO;
        public ProductManagementController(IProductBO _productBO)
        {
            this._productBO = _productBO;


        }
        // GET: api/ProductManagement
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productBO.getProductsBO();
        }

        // GET: api/ProductManagement/5
        [HttpGet("{id}", Name = "Get")]
        public Product Get(int id)
        {
            return _productBO.getProductBO(id);

        }

        // POST: api/ProductManagement
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _productBO.AddProduct(value);
        }

        // PUT: api/ProductManagement/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _productBO.UpdateProduct(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productBO.DeleteProduct(id);
        }
    }
}
