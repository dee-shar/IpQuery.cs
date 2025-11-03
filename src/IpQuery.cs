using System.Net.Http;

namespace IpQueryApi
{
    public class IpQuery
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.ipquery.io";
        public IpQuery()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36");
        }

        public async Task<string> GetMyIp()
        {
            var response = await httpClient.GetAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetIpInfo(string ip)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{ip}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
