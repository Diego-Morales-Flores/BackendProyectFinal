using System.Text.Json;

namespace BakeryFreshBreadConsole
{
    public  class API
    {
        static readonly HttpClient client = new();
        public static async Task<List<T>> GetList<T>(string path)
        {
            List<T> offices = new();
            HttpResponseMessage response = await client.GetAsync(path);
            
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                //office = await response.Content.ReadAsAsync<Office>();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                offices = JsonSerializer.Deserialize<List<T>>(result, options);
            }
            return offices;
        }

        public static async Task<T> Create<T>(string path, T entity)
        {
            string json = JsonSerializer.Serialize(entity);

            StringContent httpContent = new(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(path, httpContent);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                //office = await response.Content.ReadAsAsync<Office>();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var entityCreated = JsonSerializer.Deserialize<T>(result, options);
                return entityCreated;
            }
            return entity;
            
        }
    }
}
