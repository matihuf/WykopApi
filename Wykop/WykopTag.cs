using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wykop.Models;

namespace Wykop
{
    public class WykopTag : WykopBase
    {
        public WykopTag(HttpClient httpClient, WykopAccess wykopAccess) : base(httpClient, wykopAccess)
        {
        }

        public async Task<WykopTagResult> GetTags(string tag, TagMethods method)
        {
            string json = await GetResponseAsync(GetRequestUrl(tag, method.ToString()));
            return JsonConvert.DeserializeObject<WykopTagResult>(json);
        }

        private string GetRequestUrl(string tag, string method)
        {
            StringBuilder apiRequestUrl = new StringBuilder();
            apiRequestUrl.Append(base.wykopAccess.ApiUrl);

            apiRequestUrl.Append("tag");
            apiRequestUrl.Append("/");
            apiRequestUrl.Append(method);
            apiRequestUrl.Append("/");
            apiRequestUrl.Append(tag.Replace("#", string.Empty));
            apiRequestUrl.Append("/");

            apiRequestUrl.Append("appkey,");
            apiRequestUrl.Append(base.wykopAccess.Key);
            return apiRequestUrl.ToString();
        }
    }
}
