using System.Net;

namespace API.Common.Response.Model.Responses
{
    public sealed class BadRequestResponse(string message) 
        : ApiBaseResponse(message, (int)HttpStatusCode.BadRequest)
    { }
}