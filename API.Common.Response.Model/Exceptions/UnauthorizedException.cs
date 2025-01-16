namespace API.Common.Response.Model.Exceptions
{
    public class UnauthorizedException(string message) 
        : Exception(message) { }
}
