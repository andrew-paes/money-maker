using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// MaritalStatuss
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MaritalStatusController : ControllerBase
    {
        private readonly IMaritalStatusService _service;

        public MaritalStatusController(IMaritalStatusService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all MaritalStatus
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">List of MaritalStatus found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<MaritalStatus>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<MaritalStatus>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get MaritalStatus by Id
        /// </summary>
        /// <param name="id">MaritalStatus Id</param>
        /// <returns>MaritalStatus object</returns>
        /// <response code="201">MaritalStatus found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MaritalStatus), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<MaritalStatus> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// Insert a new MaritalStatus
        /// </summary>
        /// <param name="entity">MaritalStatus model object</param>
        /// <returns>MaritalStatus object</returns>
        /// <response code="201">MaritalStatus created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(MaritalStatus), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<MaritalStatus> Post([FromBody] MaritalStatus entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known MaritalStatus
        /// </summary>
        /// <param name="entity">MaritalStatus model object</param>
        /// <param name="id">MaritalStatus Id</param>
        /// <returns>MaritalStatus object</returns>
        /// <response code="201">MaritalStatus updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(MaritalStatus), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<MaritalStatus> Put([FromBody] MaritalStatus entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know MaritalStatus
        /// </summary>
        /// <param name="id">MaritalStatus Id</param>
        /// <returns>MaritalStatus object</returns>
        /// <response code="201">MaritalStatus deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}