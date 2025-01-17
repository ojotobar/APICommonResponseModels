using System.Net;

namespace API.Common.Response.Model.Responses
{
    public sealed class InternalServerErrorResponse(string message) 
        : ApiBaseResponse(message, (int)HttpStatusCode.InternalServerError)
    { }
}
