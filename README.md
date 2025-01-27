# LinkedIn API Client Kullanımı

Bu proje, RapidAPI üzerinden LinkedIn profil bilgilerini almayı kolaylaştıran bir C# uygulamasıdır. Basit ve anlaşılır bir şekilde LinkedIn verilerine erişmek isteyenler için tasarlanmıştır. Benzer şekilde Rapid Apilere request atabilirsiniz.

## 📌 Gereksinimler
- .NET 6 veya daha yeni bir sürüm
- RapidAPI hesabı
- LinkedIn Data API erişim anahtarı

## 🚀 Kurulum ve Kullanım

### 1. **RapidAPI Anahtarlarını Alın**
- [RapidAPI LinkedIn Data API](https://rapidapi.com/) üzerinden bir hesap oluşturun.
- API anahtarınızı ve host bilgilerinizi alın.

### 2. **ApiConstants.cs Dosyası Oluşturun**
`ApiConstants` sınıfı, API anahtarlarını merkezi bir yerde yönetmek için kullanılır.

```csharp
public static class ApiConstants
{
    public const string ApiKey = "YOUR_RAPIDAPI_KEY";
    public const string ApiHostLinkedin = "linkedin-data-api.p.rapidapi.com";
}
```

### 3. **LinkedInClient.cs Dosyasını Kullanın**

Bu sınıf, LinkedIn API'ye istek göndermek ve yanıtı `LinkedInResponse` nesnesine çevirmek için geliştirilmiştir.

```csharp
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

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
            RequestUri = new Uri($"https://{ApiConstants.ApiHost}/?username={username}"),
        };

        request.Headers.Add("x-rapidapi-key", ApiConstants.ApiKey);
        request.Headers.Add("x-rapidapi-host", ApiConstants.ApiHost);

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
```
 

### 5. **Program.cs İçinde Kullanımı**

Bu istemciyi `Main` metodunda çağırarak test edebilirsiniz.

```csharp
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var linkedInClient = new LinkedInClient();
        string username = "adamselipsky";

        var profileData = await linkedInClient.GetProfileDataAsync(username);

        if (profileData != null)
        {
            Console.WriteLine("LinkedIn Profili:");
            Console.WriteLine($"Ad: {profileData.Name}");
            Console.WriteLine($"Başlık: {profileData.Headline}");
            Console.WriteLine($"Konum: {profileData.Location}");
            Console.WriteLine($"Profil URL: {profileData.ProfileUrl}");
        }
        else
        {
            Console.WriteLine("Profil bilgileri alınamadı.");
        }
    }
}
```

## 🎯 Hata Yönetimi
- **`HttpRequestException`**: API bağlantı sorunları için yakalanır.
- **`JsonException`**: Yanıt JSON formatı hatalarında yakalanır.

## 📌 Notlar
- API anahtarınızı `.gitignore` veya bir **çevresel değişken** içinde saklamanız önerilir.
- Yanıt formatı değişirse `LinkedInResponse` modelini güncellemeniz gerekebilir.

## 🔹 Geliştirme Önerileri
- API yanıtlarını daha fazla veriyle genişletmek için `LinkedInResponse` modeline yeni alanlar ekleyebilirsiniz.
- Daha sağlam bir hata yönetimi sağlamak için **retry mekanizması** ekleyebilirsiniz.
- `HttpClient` nesnesini **dependency injection** ile yöneterek performansı artırabilirsiniz.

🚀 **Başarılar!**

