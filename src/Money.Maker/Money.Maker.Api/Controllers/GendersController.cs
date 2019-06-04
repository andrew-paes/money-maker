using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Genders
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IGenderService _service;

        public GendersController(IGenderService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all Genders
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">List of Genders found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Gender>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<Gender>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get Gender by Id
        /// </summary>
        /// <param name="id">Gender Id</param>
        /// <returns>Gender object</returns>
        /// <response code="201">Gender found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Gender), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Gender> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// Insert a new Gender
        /// </summary>
        /// <param name="entity">Gender model object</param>
        /// <returns>Gender object</returns>
        /// <response code="201">Gender created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(Gender), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Gender> Post([FromBody] Gender entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known Gender
        /// </summary>
        /// <param name="entity">Gender model object</param>
        /// <param name="id">Gender Id</param>
        /// <returns>Gender object</returns>
        /// <response code="201">Gender updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Gender), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Gender> Put([FromBody] Gender entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know Gender
        /// </summary>
        /// <param name="id">Gender Id</param>
        /// <returns>Gender object</returns>
        /// <response code="201">Gender deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}