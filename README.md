# IpQuery.cs
Web-API for [ipquery.io](https://ipquery.io) which offers a flexible api for vpn detection, geolocation, and threat intelligence.

## Example
```cs
using IpQueryApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new IpQuery();
            string myIp = await api.GetMyIp();
            Console.WriteLine(myIp);
        }
    }
}
```
