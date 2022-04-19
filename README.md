# IPGeo

## Summary
This is a <strong>C# (.NET 6)</strong> library that provides simple means of obtaining geolocation and other IP-related data from the [IP Geolocation API](https://ip-api.com/).

## Status
[![NuGet Badge](https://buildstats.info/nuget/IPGeo)](https://www.nuget.org/packages/IPGeo)

## Methods
There is one <strong>asynchronous</strong> method which return an Object containing all the relevant information for a given IP addres:
```Csharp
GetGeoData(string ip)
```

## Example usage
```Csharp
using IPGeo;

var geoController = new GeoController();
var ipData = await geoController.GetGeoData("24.48.0.1");

if (ipData.Status == "success")
{
    Console.WriteLine($"The user with IP: {ipData.IP} is located in {ipData.City}, {ipData.Country}"); 
}
else
{
    Console.WriteLine($"The provided IP ({ipData.IP}) is invalid");
}

```
This will produce the following result:
```
The user with IP: 24.48.0.1 is located in Montreal, Canada
```
*The IP address used in the above example comes from [IP Geolocation API's Documentation](https://ip-api.com/).*

## Installation
*NuGet package to come*

## License
Copyright © 2022 Ivan Gechev.

This package has MIT license. Refer to the [LICENSE](https://github.com/Banovvv/IPGeo/blob/81d87f5fe1c35a80aaeae7d923195a0e49514dd1/LICENSE) for detailed information.

## Questions, comments or additions
If you have a feature request or bug report, [open a new Issue](https://github.com/Banovvv/IPGeo/issues/new) or [send a Pull request](https://github.com/Banovvv/IPGeo/pulls).

## Support
If you like this project, give it a ⭐ and share it with friends!
