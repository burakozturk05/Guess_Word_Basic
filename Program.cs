
string[] kelimeler =new string[] { "Ahmet", "Mehmet", "Burak", "Sadık", "Remzi", "Ayşe" };
Console.WriteLine(string.Join(" ",kelimeler));
Random random = new Random();
int tahminEdilen = random.Next(0, 6);

Console.WriteLine("Lutfen tahmininizi girin.");
bool gecerlimi = false;
int hak = 3;
while (hak > 0)
{
    string kelime = Console.ReadLine().Trim().ToLower();
    bool bosmu = string.IsNullOrEmpty(kelime);
    if (bosmu || int.TryParse(kelime, out int _))
    {
        Console.WriteLine("Lutfen Doğru bir karakter giriniz.");
        hak--;
    }
    if (!(bosmu || int.TryParse(kelime, out int _)))
    {
        if (kelime == kelimeler[tahminEdilen].ToLower())
        {
            Console.WriteLine("Doğru;");
            break;
        }
        if (!(kelime == kelimeler[tahminEdilen].ToLower()))
        {
            Console.WriteLine($"Yanlış.. Kelime '{kelimeler[tahminEdilen]}' olacaktı... YENİDEN DENEYİN");
            hak--;
        }
    }
}



