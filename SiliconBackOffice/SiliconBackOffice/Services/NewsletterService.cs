using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SiliconBackOffice.Models;
using System.Text.Json;
using System.Text;

namespace SiliconBackOffice.Services
{
    public class NewsletterService
    {
        private readonly HttpClient _http;
        private const string BaseUrl = "https://subscriptionprovider-silicon.azurewebsites.net/api/";

        public NewsletterService(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<NewsletterModel>> GetSubscribersAsync()
        {
            try
            {
                var result = await _http.GetAsync(BaseUrl + "GetSubscribersFunction?code=VdUem1ardDpuXjfbHNodWR6NRuTneq6ZTFo3n_8r7fHZAzFutbdzXA==");
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadFromJsonAsync<IEnumerable<NewsletterModel>>() ?? Enumerable.Empty<NewsletterModel>();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to retrieve subscribers", ex);
            }
            return Enumerable.Empty<NewsletterModel>();
        }

        public async Task<NewsletterModel> GetSubscriberAsync(string email)
        {
            try
            {
                var requestData = new { Email = email };
                var content = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");
                var result = await _http.PostAsync(BaseUrl + "GetSubscribersFunction?code=VdUem1ardDpuXjfbHNodWR6NRuTneq6ZTFo3n_8r7fHZAzFutbdzXA==", content);
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadFromJsonAsync<NewsletterModel>() ?? throw new InvalidOperationException("Failed to deserialize response.");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Failed to retrieve subscriber: {email}", ex);
            }
            return null!;
        }

        public async Task<bool> UpdateSubscriberAsync(NewsletterModel model)
        {
            try
            {
                var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
                var result = await _http.PostAsync(BaseUrl + "UpdateSubscriberFunction?code=bdOaYycwsJU9tdvHb_O_8pnk56JT8VFcZ7QpqqTrp5pRAzFuV3OoQQ==", content);
                return result.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {   
                throw new ApplicationException("Failed to update subscriber", ex);
            }
        }
    }
}