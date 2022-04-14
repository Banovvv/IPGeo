using Microsoft.Extensions.Configuration;
using System.Web.Http;

namespace IPGeo
{
	public class GeoController : ApiController
	{
		private readonly string _baseUrl = $"http://ip-api.com/json/";
	}
}