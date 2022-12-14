using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using Journal.API.Core.DTOs.Responses;

namespace Journal.API.Controllers
{
    public class BaseController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Validate(dynamic request)
        {
            if (request == null)
            {
                return BadRequest(new BaseResponse { StatusCode = "01", Status = "fail", Message = "Null object detected!" });
            }
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                    .Where(y => y.Count > 0)
                    .ToList();
                var error = errors.Select(x => x.Select(y => y.ErrorMessage)).ToList();
                return BadRequest(new BaseResponse { StatusCode = "01", Status = "fail", Message = error.First().First() });
            }
            return null;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult ValidateLong(string request)
        {
            if (string.IsNullOrEmpty(request))
            {
                return BadRequest(new BaseResponse { StatusCode = "01", Status = "fail", Message = "Null object detected!" });
            }
            if (!Regex.Match(request, "^[0-9]+$").Success)
            {
                return BadRequest(new BaseResponse { StatusCode = "01", Status = "fail", Message = "Invalid data supplied" });
            }
            return null;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public long CustomerId()
        {
            return Convert.ToInt64(User.Identity.Name);
        }


    }
}
