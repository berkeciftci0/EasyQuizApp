using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sınavınıza Hoş Geldiniz!");

        // Sorular ve cevapları tanımlayın
        string[] sorular =
        {
            "1. Başkentimiz nedir?", "2. En büyük gezegen hangisidir?", "3. Türkiye'nin en yüksek dağı hangisidir?",
            "4. Hangi gezegen 'Kırmızı Gezegen' olarak bilinir?", "5. E=mc^2 formülü kimin tarafından ortaya atılmıştır?",
            "6. En büyük okyanus hangisidir?", "7. Bir metrenin kaç santimetre olduğu kaç milimetredir?",
            "8. Hangi programlama dilini C# tabanlı bir dil olarak adlandırabiliriz?", "9. Türkiye'nin en kalabalık şehri hangisidir?",
            "10. Bir yıl kaç gündür?", "11. Hangi gezegen Güneş Sistemi'ndeki en küçük gezegendir?",
            "12. Türkiye'nin en uzun nehiri hangisidir?", "13. Hangi renk gökkuşağının en üstündedir?",
            "14. Bir bilgisayarın temel bellek birimi nedir?", "15. Hangi elementin sembolü 'O' harfi ile gösterilir?",
            "16. Türkiye'nin en batıdaki ilidir?", "17. İlk bilgisayar programcısı kimdir?",
            "18. Dünya'nın en uzun dağ sırası hangisidir?", "19. Hangi yıl Microsoft şirketi kurulmuştur?",
            "20. Dünya'nın en büyük okyanusu hangisidir?"
        };

        string[] dogruCevaplar =
        {
            "Ankara", "Jüpiter", "Ağrı Dağı", "Mars", "Albert Einstein", "Pasifik Okyanusu",
            "100", "C#", "İstanbul", "365", "Pluto", "Kızılırmak", "Mor", "Byte", "Oksijen",
            "Edirne", "Ada Lovelace", "And Dağları", "1975", "Pasifik Okyanusu"
        };

        int dogruSayisi = 0;

        // Her soruyu sorun ve cevapları kontrol edin
        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine(sorular[i]);
            string cevap = Console.ReadLine();

            if (cevap.ToLower() == dogruCevaplar[i].ToLower())
            {
                Console.WriteLine("Doğru!\n");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine($"Yanlış! Doğru cevap: {dogruCevaplar[i]}\n");
            }
        }

        // Sonuçları görüntüleyin
        Console.WriteLine($"Sınav sona erdi. Toplam doğru sayısı: {dogruSayisi} / {sorular.Length}");

        // Kullanıcıdan çıkış yapmasını isteyin
        Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basın...");
        Console.ReadKey();
    }
}
