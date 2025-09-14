using System;
using System.Net.Http;
using System.Threading.Tasks;

class CoindeskApiClient
{
    static async Task Main(string[] args)
    {
        string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Coindesk API Response:");
                Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
