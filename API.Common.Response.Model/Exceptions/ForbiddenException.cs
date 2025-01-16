namespace API.Common.Response.Model.Exceptions
{
    public class ForbiddenException(string message) 
        : Exception(message) { }
}
