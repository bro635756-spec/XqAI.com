using System;
using XqAI.Security;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Title = "XqAI.com | Cloud Engine v1.0";
        Console.WriteLine("XqAI Başlatılıyor...");

        FirebaseManager fb = new FirebaseManager();
        bool isSecure = await fb.AuthenticateSystem();

        if (isSecure)
        {
            Console.WriteLine("Sistem Güvenli. GitHub Senkronizasyonu Aktif.");
            fb.LogActivity("XqAI Cloud Online");
            
            // XqAI Sohbet Başlatıcı
            StartChat();
        }
    }

    static void StartChat()
    {
        Console.WriteLine("\nXqAI: Merhaba Burak, sistem hazır.");
        while (true)
        {
            Console.Write("Burak: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;
            
            Console.WriteLine("XqAI: Komut işleniyor (Firebase & GitHub senkronize)...");
        }
    }
}
