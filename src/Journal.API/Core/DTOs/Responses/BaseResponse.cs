using Journal.API.Core.Interfaces;

namespace Journal.API.Core.DTOs.Responses
{
    public class BaseResponse : IResponse
    {
        public string Status { get; set; } = "success";
        public string StatusCode { get; set; } = "00";
        public string Message { get; set; }
    }

    public class SuccessResponse : BaseResponse
    {
        public dynamic Data { get; set; }
        public SuccessResponse(string message, dynamic data = null, string statuscode = "00", string status = "success")
        {
            Status = status;
            StatusCode = statuscode;
            Message = message;
            Data = data;
        }
    }

    public class FailureResponse : BaseResponse
    {
        public FailureResponse(string statusCode, string message)
        {
            Status = "failed";
            StatusCode = statusCode;
            Message = message;
        }
    }

}
