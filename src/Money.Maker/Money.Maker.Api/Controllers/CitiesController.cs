using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Domain.ResponseModel;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Brazilian Cities
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _service;

        public CitiesController(ICityService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all Cities
        /// </summary>
        /// <returns>List of City object</returns>
        /// <response code="201">List of Cities found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<City>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<City>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get City by Id
        /// </summary>
        /// <param name="id">City Id</param>
        /// <returns>City object</returns>
        /// <response code="201">City found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(City), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<City> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// List all Cities By State
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns>List of ViewCity object</returns>
        /// <response code="201">List of ViewCity found</response>
        /// <response code="400">No results found</response>
        [HttpGet("State/{stateId}")]
        [ProducesResponseType(typeof(ViewCity), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<ViewCity> GetByStateId(int stateId) => Ok(_service.GetByStateId(stateId));

        /// <summary>
        /// Insert a new City
        /// </summary>
        /// <param name="entity">City model object</param>
        /// <returns>City object</returns>
        /// <response code="201">City created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(City), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<City> Post([FromBody] City entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known City
        /// </summary>
        /// <param name="entity">City model object</param>
        /// <param name="id">City Id</param>
        /// <returns>City object</returns>
        /// <response code="201">City updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(City), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<City> Put([FromBody] City entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know City
        /// </summary>
        /// <param name="id">City Id</param>
        /// <returns>City object</returns>
        /// <response code="201">City deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}