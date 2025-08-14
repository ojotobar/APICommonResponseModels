using API.Common.Response.Model.Models;
using API.Common.Response.Model.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Common.Response.Model.ControllerHelpers
{
    public class ApiControllerBase : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult ProcessError(ApiBaseResponse baseResponse)
        {
            return baseResponse switch
            {
                NotFoundResponse => NotFound(new ErrorModel
                {
                    Message = ((NotFoundResponse)baseResponse).Message,
                    StatusCode = StatusCodes.Status404NotFound
                }),
                BadRequestResponse => BadRequest(new ErrorModel
                {
                    Message = ((BadRequestResponse)baseResponse).Message,
                    StatusCode = StatusCodes.Status400BadRequest
                }),
                UnauthorizedResponse => StatusCode(StatusCodes.Status401Unauthorized, new ErrorModel
                {
                    Message = ((UnauthorizedResponse)baseResponse).Message,
                    StatusCode = StatusCodes.Status401Unauthorized
                }),
                ForbiddenResponse => StatusCode(StatusCodes.Status403Forbidden, new ErrorModel
                {
                    Message = ((ForbiddenResponse)baseResponse).Message,
                    StatusCode = StatusCodes.Status403Forbidden
                }),
                _ => StatusCode(StatusCodes.Status501NotImplemented)
            };
        }
    }
}
