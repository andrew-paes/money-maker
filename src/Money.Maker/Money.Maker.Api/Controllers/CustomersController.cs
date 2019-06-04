using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Customers
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all Customers
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">List of Customers found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Customer>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<Customer>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get Customer by Id
        /// </summary>
        /// <param name="id">Customer Id</param>
        /// <returns>Customer object</returns>
        /// <response code="201">Customer found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Customer), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Customer> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// Insert a new Customer
        /// </summary>
        /// <param name="entity">Customer model object</param>
        /// <returns>Customer object</returns>
        /// <response code="201">Customer created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(Customer), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Customer> Post([FromBody] Customer entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known Customer
        /// </summary>
        /// <param name="entity">Customer model object</param>
        /// <param name="id">Customer Id</param>
        /// <returns>Customer object</returns>
        /// <response code="201">Customer updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Customer), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Customer> Put([FromBody] Customer entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know Customer
        /// </summary>
        /// <param name="id">Customer Id</param>
        /// <returns>Customer object</returns>
        /// <response code="201">Customer deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}