namespace Journal.API.Core.Interfaces
{
    public interface IResponse
    {
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
    }
}
