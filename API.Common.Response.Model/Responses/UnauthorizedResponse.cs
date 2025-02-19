﻿using System.Net;

namespace API.Common.Response.Model.Responses
{
    public sealed class UnauthorizedResponse(string message)
        : ApiBaseResponse(message, (int)HttpStatusCode.Unauthorized) { }
}
