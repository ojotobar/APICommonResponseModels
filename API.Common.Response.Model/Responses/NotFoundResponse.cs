using System.Net;

namespace API.Common.Response.Model.Responses
{
    public sealed class NotFoundResponse(string message) :
        ApiBaseResponse(message, (int)HttpStatusCode.NotFound) { }
}
