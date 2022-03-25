using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace parser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string sourse = null;

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }
            
            return sourse;
        }
    }
}
