using Microsoft.AspNetCore.Mvc;
using Product_API.Interface;
using Product_API.Model;
using System;
using System.Collections.Generic;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/Product
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET api/Product
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var items = _service.GetAllItems();
            return Ok(items);
        }

        // GET api/Product/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(Guid id)
        {
            var item = _service.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST api/Product
        [HttpPost]
        public ActionResult Post([FromBody] Product value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _service.Add(value);
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        // DELETE api/Product/5
        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id)
        {
            var existingItem = _service.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _service.Remove(id);
            return Ok();
        }
    }
}
