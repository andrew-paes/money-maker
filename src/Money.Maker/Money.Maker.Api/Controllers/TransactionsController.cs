using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Money.Maker.Domain.DataModels;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Api.Controllers
{
    /// <summary>
    /// Brazilian Transactions
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _service;

        public TransactionsController(ITransactionService service)
        {
            _service = service;
        }

        /// <summary>
        /// List all Transactions
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        /// <response code="201">List of Transactions found</response>
        /// <response code="400">No results found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Transaction>), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<IEnumerable<Transaction>> GetList() => Ok(_service.Get());

        /// <summary>
        /// Get Transaction by Id
        /// </summary>
        /// <param name="id">Transaction Id</param>
        /// <returns>Transaction object</returns>
        /// <response code="201">Transaction found</response>
        /// <response code="400">Id invalid</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Transaction), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Transaction> Get(int id) => Ok(_service.Get(id));

        /// <summary>
        /// Insert a new Transaction
        /// </summary>
        /// <param name="entity">Transaction model object</param>
        /// <returns>Transaction object</returns>
        /// <response code="201">Transaction created</response>
        /// <response code="400">Model invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(Transaction), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Transaction> Post([FromBody] Transaction entity) => Ok(_service.Add(entity));

        /// <summary>
        /// Update a known Transaction
        /// </summary>
        /// <param name="entity">Transaction model object</param>
        /// <param name="id">Transaction Id</param>
        /// <returns>Transaction object</returns>
        /// <response code="201">Transaction updated</response>
        /// <response code="400">Model invalid</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Transaction), 201)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<Transaction> Put([FromBody] Transaction entity, int id) => Ok(_service.Update(entity, id));

        /// <summary>
        /// Delete a know Transaction
        /// </summary>
        /// <param name="id">Transaction Id</param>
        /// <returns>Transaction object</returns>
        /// <response code="201">Transaction deleted</response>
        /// <response code="400">Id invalid</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 400)]
        public void Delete(int id) => Ok(_service.Delete(id));
    }
}