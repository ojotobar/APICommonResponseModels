﻿using System.Net;

namespace API.Common.Response.Model.Responses
{
    public sealed class ApiOkResponse<TResult> (TResult result)
        : ApiBaseResponse("Successful", (int)HttpStatusCode.OK, true)
    {
        public TResult Result { get; set; } = result;
    }
}
