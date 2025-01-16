namespace API.Common.Response.Model.Responses
{
    public abstract class ApiBaseResponse(string message, int statusCode, bool success = false)
    {
        public string Message { get; set; } = message;
        public int StatucCode { get; set; } = statusCode;
        public bool Success { get; set; } = success;
    }
}
