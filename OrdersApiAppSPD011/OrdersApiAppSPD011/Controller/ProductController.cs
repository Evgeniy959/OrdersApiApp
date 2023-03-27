using Microsoft.AspNetCore.Mvc;
using OrdersApiAppSPD011.Model.Entity;
using OrdersApiAppSPD011.Service.ClientService;

namespace OrdersApiAppSPD011.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IDaoProduct daoProduct;

        public ProductController(IDaoProduct daoProduct)
        {
            this.daoProduct = daoProduct;
        }

        // GET: /product/all
        [HttpGet("all")]
        public async Task<List<Product>> GetAll()
        {
            return await daoProduct.GetAllAsync();
        }

        // GET product/{id}
        //[HttpGet("{id}")]
        [HttpGet("get")]
        public async Task<Product> Get(int id)
        {
            return await daoProduct.GetAsync(id);
        }

        // POST product/add
        [HttpPost("add")]
        public async Task<Product> Post(/*[FromBody]*/ Product product)
        {
            return await daoProduct.AddAsync(product);
        }

        // PUT product/update/{id}
        /*[HttpPost("update/{id}")]
        public async Task<Product> Put(int id, [FromBody] Product product)
        {
            product.Id = id;
            return await daoProduct.UpdateAsync(product);
        }*/
        //[HttpPost("update/{id}")]
        [HttpPost("update")]
        public async Task<Product> Update(/*int id, [FromBody]*/ Product product)
        {
            //product.Id = id;
            return await daoProduct.UpdateAsync(product);
        }

        // DELETE product/delete/{id}
        [HttpDelete("delete/{id}")]
        public async Task<Product> Delete(int id)
        {
            return await daoProduct.DeleteAsync(id);
        }


        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
