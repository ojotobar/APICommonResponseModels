namespace API.Common.Response.Model.Models
{
    public class ErrorModel
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; }
    }
}