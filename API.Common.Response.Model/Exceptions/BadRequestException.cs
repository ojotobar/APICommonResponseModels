namespace API.Common.Response.Model.Exceptions
{
    public class BadRequestException(string message) 
        : Exception(message) { }
}