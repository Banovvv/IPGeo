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
		public string Message { get; }
		public string Continent { get; }
		public string ContinentCode { get; }
		public string Country { get; }
		public string CountryCode { get; }
		public string Region { get; }
		public string RegionName { get; }
		public string City { get; }
		public string District { get; }
		public string Zip { get; }
		public double Latitude { get; }
		public double Longitude { get; }
		public string Timezone { get; }
		public string TimezoneOffset { get; }
		public string Currency { get; }
		public string ISP { get; }
		public string OrganizationName { get; }
		public string As { get; }
		public string AsName { get; }
		public string Reverse { get; }
		public bool Mobile { get; }
		public bool Proxy { get; }
		public bool Hosting { get; }
		public string IP { get; }
	}
}
