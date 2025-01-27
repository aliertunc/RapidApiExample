using System.Text.Json;

public class LinkedInClient
{
    private readonly HttpClient _client;
  
    public LinkedInClient()
    {
        _client = new HttpClient();
    }

    public async Task<LinkedInResponse> GetProfileDataAsync(string username)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://{ApiConstants.ApiHostLinkedin}/?username={username}"),
        };

        request.Headers.Add("x-rapidapi-key", ApiConstants.ApiKey);
        request.Headers.Add("x-rapidapi-host", ApiConstants.ApiHostLinkedin);


        try
        {
            using var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<LinkedInResponse>(responseBody);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP Hatası: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON Çözümleme Hatası: {ex.Message}");
        }

        return null;
    }
}
