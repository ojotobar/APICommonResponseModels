namespace API.Common.Response.Model.Exceptions
{
    public class NotFoundException(string message) 
        : Exception(message) { }
}
