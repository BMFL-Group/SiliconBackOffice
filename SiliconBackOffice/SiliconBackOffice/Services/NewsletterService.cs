using SiliconBackOffice.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SiliconBackOffice.Services
{
    public class NewsletterService
    {
        private readonly HttpClient _http;
        private readonly IConfiguration _config;

        public NewsletterService(HttpClient http, IConfiguration config)
        {
            _http = http;
            _config = config;
        }

        public async Task<IEnumerable<NewsletterModel>> GetSubscribersAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://newsletterprovider-bmfl.azurewebsites.net/api/getsubscriber?code=tPCFhF1FQuVYEQYn83tYTYUyYadZjTh6C2dhPSRKUFhLAzFuqRMTVw%3D%3D");
            var response = await _http.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IEnumerable<NewsletterModel>>(json) ?? Enumerable.Empty<NewsletterModel>();
            }
            else
            {
                Console.WriteLine($"Failed to fetch subscribers: {response.StatusCode}");
                return Enumerable.Empty<NewsletterModel>();
            }
        }

        public async Task<bool> UpdateSubscriberAsync(NewsletterModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://newsletterprovider-bmfl.azurewebsites.net/api/Subscribe?code=jYf27X54n1bcCN5_hkPi-bEE5pcSX2kp_Uiplh0QDiUsAzFuZanPRg%3D%3D")
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await _http.SendAsync(request);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UnsubscribeAsync(string email)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://newsletterprovider-bmfl.azurewebsites.net/api/Unsubscribe?code=nf9P6RZL4OXjbD3jR7W5dfIUVFwH4UlJK0Fb3RglfPAbAzFuOdFs1A%3D%3D&email={email}");
            var response = await _http.SendAsync(request);
            return response.IsSuccessStatusCode;
        }
    }
}