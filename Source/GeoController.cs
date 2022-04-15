using Microsoft.Extensions.Configuration;
using System.Web.Http;

namespace IPGeo
{
	public class GeoController : ApiController
	{
		private readonly string _baseUrl = @"http://ip-api.com/json/{query}?fields=66846719";

        public GeoController()
        {

        }

		public async Task<IPResponse> GetGeoData(string ip)
        {
            Uri baseAddress = new Uri(_baseUrl.Replace("{query}", ip));

            var client = new HttpClient()
            {
                BaseAddress = baseAddress
            };

            var queryResponse= await client.GetAsync(baseAddress);

            var jsonContent = await queryResponse.Content.ReadAsStringAsync();

            IPResponse ipResponse = new IPResponse(jsonContent);

            return ipResponse;
        }
	}
}