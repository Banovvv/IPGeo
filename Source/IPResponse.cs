using Newtonsoft.Json.Linq;

namespace IPGeo
{
    public class IPResponse
    {
        public IPResponse(string jsonResponse)
        {
            JObject data = JObject.Parse(jsonResponse);
            Status = data.SelectToken("status").ToString();

            if (Status == "success")
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
                TimezoneOffset = int.Parse(data.SelectToken("offset").ToString());
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

        /// <summary>
        /// Status of the request - success or fail
        /// </summary>
        public string Status { get; }
        /// <summary>
        /// Included only when status is fail
        /// </summary>
        public string Message { get; }
        /// <summary>
        /// Continent name
        /// </summary>
        public string Continent { get; }
        /// <summary>
        /// Two-letter continent code	
        /// </summary>
        public string ContinentCode { get; }
        /// <summary>
        /// Country name
        /// </summary>
        public string Country { get; }
        /// <summary>
        /// Two-letter country code
        /// </summary>
        public string CountryCode { get; }
        /// <summary>
        /// Region/state short code
        /// </summary>
        public string Region { get; }
        /// <summary>
        /// Region/state
        /// </summary>
        public string RegionName { get; }
        /// <summary>
        /// City
        /// </summary>
        public string City { get; }
        /// <summary>
        /// District (subdivision of city)
        /// </summary>
        public string District { get; }
        /// <summary>
        /// Zip code
        /// </summary>
        public string Zip { get; }
        /// <summary>
        /// Latitude
        /// </summary>
        public double Latitude { get; }
        /// <summary>
        /// Longitude
        /// </summary>
        public double Longitude { get; }
        /// <summary>
        /// Timezone
        /// </summary>
        public string Timezone { get; }
        /// <summary>
        /// Timezone UTC DST offset in seconds
        /// </summary>
        public int TimezoneOffset { get; }
        /// <summary>
        /// National currency
        /// </summary>
        public string Currency { get; }
        /// <summary>
        /// ISP name
        /// </summary>
        public string ISP { get; }
        /// <summary>
        /// Organization name
        /// </summary>
        public string OrganizationName { get; }
        /// <summary>
        /// AS number and organization, separated by space (RIR). Empty for IP blocks not being announced in BGP tables.
        /// </summary>
        public string As { get; }
        /// <summary>
        /// AS name (RIR). Empty for IP blocks not being announced in BGP tables.	
        /// </summary>
        public string AsName { get; }
        /// <summary>
        /// Reverse DNS of the IP
        /// </summary>
        public string Reverse { get; }
        /// <summary>
        /// Mobile (cellular) connection
        /// </summary>
        public bool Mobile { get; }
        /// <summary>
        /// Proxy, VPN or Tor exit address
        /// </summary>
        public bool Proxy { get; }
        /// <summary>
        /// Hosting, colocated or data center
        /// </summary>
        public bool Hosting { get; }
        /// <summary>
        /// IP used for the query
        /// </summary>
        public string IP { get; }
    }
}
