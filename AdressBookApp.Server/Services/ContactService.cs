using AdressBookApp.Server.Models;
using Newtonsoft.Json;

namespace AdressBookApp.Server.Services
{
    public class ContactService
    {
        private readonly HttpClient _httpClient;
        public ContactService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://randomuser.me/api/");
        }

        public async Task<Contact?> GetRandomContact()
        {
            //var response = await _httpClient.GetFromJsonAsync<Contact>("");

            //return response;
            try
            {
                var response = await _httpClient.GetFromJsonAsync<Contact>("");

                if (response != null && response.Results != null && response.Results.Length > 0)
                {
                    return response;
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Еrror while sending the request!: {ex.Message}");
            }
        }

        public async Task<Contact?> GetUserByNameAsync(string name)
        {
            //using (var response = await _httpClient.GetAsync($"?name={name}"))
            //{
            //    response.EnsureSuccessStatusCode();
            //    var json = await response.Content.ReadAsStringAsync();

            //    return await response.Content.ReadFromJsonAsync<Contact>();
            //}
            try
            {
                var response = await _httpClient.GetFromJsonAsync<Contact>($"?name={name}");

                if (response != null && response.Results != null && response.Results.Length > 0)
                {
                    return response;
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception($"Еrror while sending the request!");
            }

        }
    }
}
