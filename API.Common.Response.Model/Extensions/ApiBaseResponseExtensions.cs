using API.Common.Response.Model.Responses;

namespace API.Common.Response.Model.Extensions
{
    public static class ApiBaseResponseExtensions
    {
        public static TResult GetResult<TResult>(this ApiBaseResponse response) =>
            ((OkResponse<TResult>)response).Result;
    }
}
