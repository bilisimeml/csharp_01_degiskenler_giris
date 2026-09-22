/*
    C# Değişkenler
    Değişken tanımlama kuralı
    1. yöntem
        veritürü degiskenAdi = veri;

    2. yöntem
        var degiskenAdi = veri;

    Değişken Adlandırma Kuralları
    1. değişken adından boşluk olmaz
    2. sayı ile başlayamaz
    3. özel karakter içermez
    4. c# (si şarp) anahtar kelimeleri kullanılmaz
    5. BÜYÜK/küçük harfe duyarlıdır
*/

// 1. Yöntem
int yas = 25;
string isim = "Ali";
bool ogrenciMi = true;

Console.WriteLine($"{isim} adlı öğrenci {yas} yaşındadır");
Console.WriteLine($"Öğrenci durum : {ogrenciMi}");