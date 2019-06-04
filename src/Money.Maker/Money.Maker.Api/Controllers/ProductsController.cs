using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Products
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all Products
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">List of Products found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<Product>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get Product by Id
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Product object</returns>
        /// <response code="201">Product found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Product> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// Insert a new Product
        /// </summary>
        /// <param name="entity">Product model object</param>
        /// <returns>Product object</returns>
        /// <response code="201">Product created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(Product), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Product> Post([FromBody] Product entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known Product
        /// </summary>
        /// <param name="entity">Product model object</param>
        /// <param name="id">Product Id</param>
        /// <returns>Product object</returns>
        /// <response code="201">Product updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Product), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Product> Put([FromBody] Product entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know Product
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Product object</returns>
        /// <response code="201">Product deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}