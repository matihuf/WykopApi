using System.Net.Http;
using System.Threading.Tasks;
using Wykop.Auth;
using Wykop.Models;

namespace Wykop
{
    public abstract class WykopBase
    {
        private HttpClient httpClient;
        protected WykopAccess wykopAccess;

        public WykopBase(HttpClient httpClient, WykopAccess wykopAccess)
        {
            this.httpClient = httpClient;
            this.wykopAccess = wykopAccess;
        }

        protected async Task<string> GetResponseAsync(string url)
        { 
            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                AuthSignature signature = new AuthSignature(this.wykopAccess.Secret, request.RequestUri);
                var hash = signature.FetchSignature();
                request.Headers.Add("apisign", hash);

                HttpResponseMessage httpResponseMessage = await this.httpClient.SendAsync(request);
                httpResponseMessage.EnsureSuccessStatusCode();
                return await httpResponseMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
