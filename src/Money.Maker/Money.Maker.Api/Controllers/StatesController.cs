using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Brazilian States
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateService _service;

        public StatesController(IStateService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all States
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">Lis of States found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<State>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<State>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get State by Id
        /// </summary>
        /// <param name="id">State Id</param>
        /// <returns>State object</returns>
        /// <response code="201">State found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(State), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<State> Get(int id) =>  Ok(_service.Get(id));

        /// <summary>
        /// Insert a new State
        /// </summary>
        /// <param name="entity">State model object</param>
        /// <returns>State object</returns>
        /// <response code="201">State created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(State), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<State> Post([FromBody] State entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known State
        /// </summary>
        /// <param name="entity">State model object</param>
        /// <param name="id">State Id</param>
        /// <returns>State object</returns>
        /// <response code="201">State updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        public ActionResult<State> Put([FromBody] State entity, int id) => Ok(_service.Update(entity,id));

        /// <summary>
        /// Delete a know State
        /// </summary>
        /// <param name="id">State Id</param>
        /// <returns>State object</returns>
        /// <response code="201">State deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}
