using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Customer's Addresses
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressesController(IAddressService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all Addresss
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">List of Addresss found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Address>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<Address>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get Address by Id
        /// </summary>
        /// <param name="id">Address Id</param>
        /// <returns>Address object</returns>
        /// <response code="201">Address found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Address), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Address> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// Insert a new Address
        /// </summary>
        /// <param name="entity">Address model object</param>
        /// <returns>Address object</returns>
        /// <response code="201">Address created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(Address), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Address> Post([FromBody] Address entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known Address
        /// </summary>
        /// <param name="entity">Address model object</param>
        /// <param name="id">Address Id</param>
        /// <returns>Address object</returns>
        /// <response code="201">Address updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Address), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Address> Put([FromBody] Address entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know Address
        /// </summary>
        /// <param name="id">Address Id</param>
        /// <returns>Address object</returns>
        /// <response code="201">Address deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}