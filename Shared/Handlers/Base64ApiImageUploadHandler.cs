using System.Net.Http;
using RapidCMS.Core.Handlers;

namespace Shared.Handlers
{
    public class Base64ApiImageUploadHandler : ApiFileUploadHandler<Base64ImageUploadHandler>, IImageUploadHandler
    {
        public Base64ApiImageUploadHandler(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
