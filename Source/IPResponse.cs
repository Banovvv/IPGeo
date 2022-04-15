using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPGeo
{
	internal class IPResponse
	{
		public IPResponse(string jsonResponse)
		{
			JObject data = JObject.Parse(jsonResponse);
			Status = data.SelectToken("status").ToString();

			if(Status == "success")
            {
				Continent = data.SelectToken("continent").ToString();
				ContinentCode = data.SelectToken("continentCode").ToString();
				Country = data.SelectToken("country").ToString();
				CountryCode = data.SelectToken("countryCode").ToString();
				Region = data.SelectToken("region").ToString();
				RegionName = data.SelectToken("regionName").ToString();
				City = data.SelectToken("city").ToString();
				District = data.SelectToken("district").ToString();
				Zip = data.SelectToken("zip").ToString();
				Latitude = double.Parse(data.SelectToken("lat").ToString());
				Longitude = double.Parse(data.SelectToken("lon").ToString());
				Timezone = data.SelectToken("timezone").ToString();
				TimezoneOffset = data.SelectToken("offset").ToString();
				Currency = data.SelectToken("currency").ToString();
				ISP = data.SelectToken("isp").ToString();
				OrganizationName = data.SelectToken("org").ToString();
				As = data.SelectToken("as").ToString();
				AsName = data.SelectToken("asname").ToString();
				Reverse = data.SelectToken("reverse").ToString();
				Mobile = (bool)data.SelectToken("mobile");
				Proxy = (bool)data.SelectToken("proxy");
				Hosting = (bool)data.SelectToken("hosting");
				IP = data.SelectToken("query").ToString();
			}
            else
            {
				Message = data.SelectToken("message").ToString();
				IP = data.SelectToken("query").ToString();
			}
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
