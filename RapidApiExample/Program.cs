using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var linkedInClient = new LinkedInClient();
        string username = "ertuncali";

        var profileData = await linkedInClient.GetProfileDataAsync(username);

        if (profileData != null)
        {
            Console.WriteLine("LinkedIn Profili:");
            Console.WriteLine($"Ad: {profileData.firstName}");
            Console.WriteLine($"Soyad: {profileData.lastName}");
            Console.WriteLine($"Başlık: {profileData.headline}");
            Console.WriteLine($"Özet: {profileData.summary}");
            Console.WriteLine($"Konum: {profileData.geo}");
            Console.WriteLine($"Profil Resmi: {profileData.profilePicture}");
            Console.WriteLine($"Eğitimler: {string.Join(", ", profileData.educations.Select(e => e.schoolName))}");
            Console.WriteLine($"Pozisyonlar: {string.Join(", ", profileData.position.Select(p => p.title))}");
            Console.WriteLine($"Yetenekler: {string.Join(", ", profileData.skills.Select(s => s.name))}");
            Console.WriteLine($"Projeler: {profileData.projects}");
            Console.WriteLine($"Desteklenen Diller: {string.Join(", ", profileData.supportedLocales.Select(l => l.language))}");
        }
        else
        {
            Console.WriteLine("Profil bilgileri alınamadı.");
        }
    }
}
