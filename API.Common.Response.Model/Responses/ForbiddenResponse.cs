using System.Net;

namespace API.Common.Response.Model.Responses
{
    public sealed class ForbiddenResponse(string message)
        : ApiBaseResponse(message, (int)HttpStatusCode.Forbidden) { }
}
