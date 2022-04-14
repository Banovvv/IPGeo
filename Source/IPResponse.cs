using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPGeo
{
	internal class IPResponse
	{
		public IPResponse()
		{

		}

		public string Status { get; }
		public string Country { get; }
		public string CountryCode { get; }
		public string Region { get; }
		public string City { get; }
		public string Zip { get; }
		public double Latitude { get; }
		public double Longitude { get; }
		public string Timezone { get; }
		public string Isp { get; }
		public string Org { get; }
		public string As { get; }
		public string Query { get; }
	}
}
