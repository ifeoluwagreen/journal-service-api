using Journal.API.Core.DTOs.Requests;
using Journal.API.Core.DTOs.Responses;
using Journal.API.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Journal.API.Controllers
{
    [Route("api/v1/journals")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IJournal _service;

        public CustomerController(ILogger<CustomerController> logger, IJournal service)
        {
            _logger = logger;
            _service = service;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateJournal([FromQuery] AddJournalRequest request)
        {
            var validate = Validate(request);
            if (validate != null) return validate;
            try
            {
                var response = _service.AddJournal(request);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}")]
        [HttpGet]
        public IActionResult GetJournal([FromRoute] Guid journalid)
        {
            try
            {
                var response = _service.GetJournal(journalid);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}")]
        [HttpDelete]
        public IActionResult DeleteJournal([FromRoute] Guid journalid)
        {
            try
            {
                var response = _service.DeleteJournal(journalid);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}")]
        [HttpPut]
        public IActionResult UpdateJournal([FromBody] AddJournalRequest request, [FromRoute] Guid journalid)
        {
            var validate = Validate(request);
            if (validate != null) return validate;

            try
            {
                var response = _service.UpdateJournal(journalid, request);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}/entries")]
        [HttpPost]
        public IActionResult CreateJournalEntry([FromQuery] AddJournalEntry request, [FromRoute] Guid journalid)
        {
            var validate = Validate(request);
            if (validate != null) return validate;
            try
            {
                var response = _service.AddJournalEntry(request, journalid);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}/entries")]
        [HttpGet]
        public IActionResult GetJournalEntries([FromRoute] Guid journalid)
        {
            try
            {
                var response = _service.GetJournalEntry(journalid);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}/entries/{entryid}")]
        [HttpDelete]
        public IActionResult DeleteJournalEntry([FromRoute] Guid journalid, [FromRoute] Guid entryid)
        {
            try
            {
                var response = _service.DeleteJournalEntry(journalid, entryid);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

        [Route("{journalid}/entries/{entryid}")]
        [HttpPut]
        public IActionResult UpdateJournalEntry([FromBody] AddJournalRequest request, [FromRoute] Guid journalid, [FromRoute] Guid entryid)
        {
            var validate = Validate(request);
            if (validate != null) return validate;

            try
            {
                var response = _service.UpdateJournalEntry(journalid, entryid, request);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new FailureResponse("99", ex.Message));
            }
        }

    }
}