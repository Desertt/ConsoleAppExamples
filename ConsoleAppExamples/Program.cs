using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExamples
{
    class Program
    {

        static void Main(string[] args)
        {


            #region 0 dan 10'a kadar yazdır

            /*
            int sayi = 10;

            for (int i = 0; i <= sayi; i++)
            {
                Console.WriteLine(i.ToString());
                
            }
            Console.ReadLine();
            */

            #endregion

            #region Klavyeden girilen 2 sayıyı yazdır
            /*
            int sayi1;
            int sayi2;
            int sonuc;
            Console.Write("Sayı1 Girin : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayi2 Girin : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi1 + sayi2;
            Console.Write("Toplama Sonucu : " + sonuc);
            Console.Read();
            */



            #endregion

            #region Girilen 3 basamaklı sayının basamaklarına ayıran örnek (Birler,Onlar,Yüzler Basamağındaki sayılar):
            ///<Algoritması >
            ///
            ///Kullanıcıdan sayı istenir.
            ///Kullanıcı sayıyı girer.
            ///alınan sayı bir değişkene aktarılır.
            ///yüzler basamağını bulmak için sayi / 100 yapılır.
            ///sayi - (yüzler basamağındaki sayi * 100) çıkarıldığında kalan basamak sayısı bulunur. 
            ///onlar basamağını bulmak için sayi / 10 yapılır.
            ///sayi - (onlar  basamağındaki sayi * 10) çıkarıldığında kalan basamak sayısı bulunur. 
            ///en son birler basamağında ki sayı ortaya çıkar.
            ///Tüm değerler ekrana yazdırılır.
            /// </Algoritması>
            /*
             int sayi;
             int yuzler;
             int onlar;
             int birler;
             Console.Write("Klavyeden Bir sayı giriniz  : ");
             sayi = Convert.ToInt32(Console.ReadLine());
             yuzler = sayi / 100;
             sayi = sayi - (yuzler * 100);
             onlar = sayi / 10;
             sayi = sayi - (onlar * 10);
             birler = sayi;
             Console.WriteLine("Yüzler Basamağı : {0}", yuzler);
             Console.WriteLine("Onlar Basamağı : {0}", onlar);
             Console.WriteLine("Birler Basamağı : {0}", birler);
             Console.ReadKey();

             */
            #endregion

            #region Girilen bir sayının asal olduğunu bulan ve bu sayıdan sonraki 5 asal sayıyı ekrana yazan program:
            ///<Algoritması >
            ///
            ///Kullanıcıdan sayı istenir.
            ///Kullanıcı sayıyı girer.
            ///SayiKontrol.cs Class'ına Kullanıcının girdiği değer parametre olarak gönderili.Class İçinde Değerin Asal Olup Olmadığı Sonuçlanır.
            ///Kullanıcıya Main Programda Asal olup olmadığı değer mesajı verdirilir.
            ///Asal Olan bi sayı için While döngüsü ile kullanıcının asal değeri sonrası 5 adet asal değer bulunur ve ekrana yazdırılır.
            /// </Algoritması>
            /* int s;
             int sayac = 0;
             Console.Write("Klavyeden bir sayı giriniz :  ");

             s = Convert.ToInt32(Console.ReadLine());
             if (SayiKontrol.asalmi(s))
             {
                 Console.Write("{0}  Girdiniz Sayı Asal", s);
             }
             else
             {
                 Console.Write("{0} Girilen Sayı Asal Değil", s);
             }

             Console.WriteLine("===========================");
             Console.WriteLine("Sonraki 5 Asal Sayı : ");
             Console.WriteLine("===========================");
             while (true)
             {
                 s++;
                 if (SayiKontrol.asalmi(s) == true)
                 {
                     Console.WriteLine("{0} Sayısı Asaldır : ", s);
                     sayac++;
                     if (sayac == 5)
                     {
                         break;
                     }
                 }


             }

             Console.ReadKey();
            */
            #endregion

            #region Klavyeden girilen bir cümledeki kelime sayısını bulunuz:
            ///<Algoritması>
            ///değişken tanımlanır.
            ///Klavyeden cümle girilmesi beklenir.
            ///cümle değişkene kelimeler halinde aktarılır.
            ///gelen kelimelerin sayısı yazdırılır.
            /*
              string cumle = "";
              Console.Write("Cümle yazın: ");
              cumle = Console.ReadLine();
              string[] kelimeler = cumle.Split(' ');
              Console.WriteLine(kelimeler.Length);
              Console.ReadKey();
            */
            #endregion

            #region Otopark Ucreti Hesaplama
            ///<İstenilen>
            ///Bir otoparka park eden
            /// Taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda 
            ///%21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. 
            ///Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.>
            /// </İstenilen>
            /// <Algoritması>
            /// Değişkenler tanımlanır 
            /// Klavyeden araç tipi ve kalınan sürenin girilmesi beklenir.
            /// Karar mekanizması araç tiplerine göre hesaplamayı yapar ve kullanıcıya sunar.
            /// </Algoritması>
            /* string taksi = "taksi", miniBus = "miniBus", ticariArac = "ticariArac";
             string aracTipi;
             double kalinanSure;
             const int taksiBirSaat = 5;
             const int miniBusBirSaat = 6;
             const double ticariAracBirSaat = 6.5;
             double taksiUcret, miniBusUcret, ticariAracUcret;
             Console.Write("Araç tipini Giriniz : ");
             aracTipi = Console.ReadLine();
             Console.ReadLine();
             Console.Write("Kalınan Süreyi Giriniz : ");
             kalinanSure = Convert.ToDouble(Console.ReadLine());
             Console.ReadLine();

             if (aracTipi == taksi)
             {
                 if (kalinanSure == 0)
                 {
                     Console.Write("Ödeme Hesaplanamadı");

                 }
                 else if (kalinanSure == 1)
                 {
                     Console.Write("Ödemeniz gereken Tutar : " + taksiBirSaat + " TL");
                 }
                 else
                 {
                     Console.Write("Ödemeniz gereken Tutar : " + (taksiBirSaat + taksiBirSaat * 20 / 100) + " TL");
                 }
                 Console.ReadLine();
             }
             else if (aracTipi == miniBus)
             {
                 if (kalinanSure == 0)
                 {
                     Console.Write("Ödeme Hesaplanamadı");

                 }
                 else if (kalinanSure == 1)
                 {
                     Console.Write("Ödemeniz gereken Tutar : " + miniBusBirSaat + " TL");
                 }
                 else
                 {
                     Console.Write("Ödemeniz gereken Tutar : " + (miniBusBirSaat + miniBusBirSaat * 21.5 / 100) + " TL");
                 }
                 Console.ReadLine();
             }

             else if (aracTipi == ticariArac)
             {
                 if (kalinanSure == 0)
                 {
                     Console.Write("Ödeme Hesaplanamadı");

                 }
                 else if (kalinanSure == 1)
                 {
                     Console.Write("Ödemeniz gereken Tutar : " + ticariAracBirSaat + " TL");
                 }
                 else
                 {
                     Console.Write("Ödemeniz gereken Tutar : " + (ticariAracBirSaat + ticariAracBirSaat * 25 / 100) + " TL");
                 }
                 Console.ReadLine();
             }

         }
            */
            #endregion

            #region AlışSatış
            ///<istenilen>
            /// Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan %3, daha fazla olanlardan ise %2 komisyon almaktadır. 
            /// Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda da toplam komisyonu
            /// ekrana yazdıran programın kodlarını yazınız.
            /// <istenilen/>
            /// <Algoritması>
            /// Değişkenler tanımlanır.
            /// Klavyeden sattığı malların fiyatını girmesi istenir.
            /// Karar mekanizması girilen malların 50 TL yukarı veya aşağısına göre komisyonunu hesaplayıp ekrana yazdırır.
            /// </Algoritması>
            /*
              double malFiyati;
              double  Sonuc;
              const int komisyon1 = 2;
              const int komisyon2 = 3;
              Console.Write("Satılan Malın Fiyatını Giriniz : ");
              malFiyati = Convert.ToInt32(Console.ReadLine());
              if (malFiyati > 0 && malFiyati < 50)
              {
                  Sonuc = (malFiyati * komisyon1) / 100;
                  Console.WriteLine("Komisyon Bedeli : " + Sonuc);
              }
              else if(malFiyati>50)
              {
                  Sonuc = malFiyati * komisyon2 / 100;
                  Console.WriteLine("Komisyon Bedeli : " + Sonuc);
              }
              Console.ReadLine();
            */
            #endregion

            #region Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran programı yazınız.
            /*
            int sayi1, sayi2, sayi3, sonuc;
            int buyuk = 0;
            int kucuk = 0;
            Console.Write("Klavyeden 1. Sayiyi Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Write("Klavyeden 2. Sayiyi Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Write("Klavyeden 3. Sayiyi Giriniz : ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("Sayi1 En Büyüktür : " + sayi1);
                buyuk = sayi1;
            }
            if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("Sayi2 En Büyüktür : " + sayi2);
                buyuk = sayi2;
            }
            if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                Console.WriteLine("Sayi3 En Büyüktür : " + sayi3);
                buyuk = sayi3;
            }
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine("Sayi1 En Küçüktür : " + sayi1);
                kucuk = sayi1;
            }
            if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                Console.WriteLine("Sayi2 En Küçüktür : " + sayi2);
                kucuk = sayi2;
            }
            if (sayi3 < sayi1 && sayi3 < sayi2)
            {
                Console.WriteLine("Sayi3 En Küçüktür : " + sayi3);
                kucuk = sayi3;

            }
            Console.WriteLine("===========Toplamları================\n");
            sonuc = buyuk + kucuk;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            */
            #endregion

            #region Maaşı ve zam oranı girilen işçinin zamlı maaşını hesaplayarak ekranda gösteren C# örneği:
            /*
            double maas,zamOrani,sonuc;
            Console.Write("İşçinin Maaş bilgisiniz giriniz : ");
            maas = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşçinin Aldığı Zam Oranını Giriniz : ");
            zamOrani = Convert.ToDouble(Console.ReadLine());
            sonuc = maas + maas * zamOrani / 100;
            Console.WriteLine("İşçinin Son Aldığı Zam İle Zamlı Maaşı : " + sonuc);
            Console.ReadLine();
            */
            #endregion

            #region DiziCalismasi 
            ///<istenilen>Elemanları tam sayı olan bir A dizisinin(20 elemanlı)
            ///rastgele sayılar atayan, sonra dizi elemanlarının aritmetik ortalamasını hesaplayan 
            ///ve elemanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın c# kodlarını yazınız.</ istenilen>

            /*20 elamanı bir değişkene atarak ekrana rastgele gelen sayıları yazdırdık.*/
            //int sayi;
            //Random RndNumber = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    sayi = RndNumber.Next(1, 20);
            //    Console.WriteLine("Rastgele Gelen Sayi : " + sayi + "\n");
            //}
            //Console.ReadLine();

            /*İstenen Program*/
            /*
            int[] dizi = new int[20]; //dizi tanımlandı veritipi[] veriAdi = new veritipi[dizide oluşacak eleman sayısı]
            double avrgNumbers;
            double topla = 0 ;
            double ortalamadanBuyukAdet = 0 , ortalamadanKucukAdet=0;
            Random RndNumber = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = RndNumber.Next(0, 20);
              
            }
            foreach (int eleman in dizi)
            {
                Console.WriteLine(eleman);
                topla += eleman;
            }
            Console.Write("===========================");
            Console.Write("Diziye Girilen Sayıların Aritmetik Ortalaması");
            Console.Write("===========================\n");
            Console.Write("Sayıların Toplamı : " + topla + "\n");
            avrgNumbers = topla / 20;
            Console.WriteLine("Aritmetik Ortalaması" + avrgNumbers);
            foreach (int dizim in dizi)
            {
                if (dizim > avrgNumbers) 
                    ortalamadanBuyukAdet += 1;
                else ortalamadanKucukAdet += 1;

            }
            Console.WriteLine("Ortalama : {0}. Ortalamadan Büyük Eleman Sayısı : {1}, Ortalamadan Küçük Eleman Sayısı : {2}", avrgNumbers, ortalamadanBuyukAdet, ortalamadanKucukAdet);
            Console.ReadKey();

            Console.Read();
            */

            #endregion

            #region  Girilen string ifadede “,” karakterlerini “.” karakteri olarak değiştiren programı yazınız.
            /* string metin = "";
             Console.Write("Metin Giriniz : ");
             metin = Console.ReadLine();
             string newMetin = metin.Replace(',', '.');
             Console.WriteLine(newMetin);
             Console.ReadKey();
            */


            #endregion

            #region Girilen String ifadede boşluk karakterine kadar olan kısmı yazdıran
            /*
             string ifade;
             Console.Write("Metin Giriniz : ");
             ifade = Console.ReadLine();
             int no = ifade.IndexOf(' ');
             Console.WriteLine(ifade.Substring(0, no));
             Console.ReadKey();
            */
            #endregion

            #region Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide, en uzun metni, en uzun metnin karakter sayısını ve en uzun metnin index numarasını bulan ve ekrana yazdıran Console Örneği:
            ///<summary>
            ///Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide,
            ///en uzun metni, en uzun metnin karakter sayısını ve en uzun metnin index 
            ///numarasını bulan ve ekrana yazdıran Console Örneği:
            ///</summary>
            /*

              string enUzunMetin = "";
              int uzunluk = 0;
              int indexNo = 0;
              string[] cumle = new string[10];
              for (int i = 0; i < 10; i++)
              {
                  Console.Write("{0}. elemanı giriniz : ", i + 1);
                  cumle[i] = Console.ReadLine();
              }

              for (int i = 0; i < 10; i++)
              {
                  if (cumle[i].Length > uzunluk)
                  {
                      uzunluk = cumle[i].Length;
                      enUzunMetin = cumle[i];
                      indexNo = i;

                  }

              }
              Console.WriteLine("====================");
              Console.WriteLine("Dizi içindeki en uzun metin: {0}", enUzunMetin);
              Console.WriteLine("Dizi içindeki en uzun metnin index numarası : {0}", indexNo);
              Console.WriteLine("Dizi içindeki en uzun metnin karakter sayısı: {0}", uzunluk);
              Console.ReadKey();

                          */

            #endregion

            #region C# Console uygulamasında Elemanları kullanıcı tarafından dışarıdan girilen 10 elemanlı bir dizinin elemanlarını %10 arttıran ve ekrana yazdıran örnek:

            /*
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}.Elemanı Giriniz  :", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
             Console.WriteLine("=========================================");
            // Yazdırma işlemi
            for(int i=0;i<10;i++)
            {
                dizi[i]=dizi[i]+(dizi[i]*10/100);
                Console.WriteLine("Dizinin {0}. indexi : {1} ", i, dizi[i]);
            }
            Console.ReadKey();
            */

            #endregion

            #region Verilen bir karakter dizininin substring() metodunu kullanarak string içerisinde arama yapan ve kaç defa geçtiğini bulan program:
            /*string metin = "";
            Console.Write("Bir metin giriniz : ");
            metin = Console.ReadLine();
            string searchBy = "abcd";
            int metinUzunluk = metin.Length;
            int searchByLength = searchBy.Length;
            int sayac = 0;
            for (int i = 0; i <=metinUzunluk-searchByLength; i++)
            {
                if (metin.Substring(i,searchByLength)==searchBy)
                {
                    sayac++;
                }
                
            }

            Console.WriteLine("Sonuc :" + sayac);
            Console.ReadKey();
            */
            #endregion

            #region Verilen bir string metnin içerisinde harf yada karakterlerin her birinden kaç adet olduğunu bulan program

            //string metin = "";
            //Console.Write("Bir Metin Giriniz : ");
            //metin = Console.ReadLine();
            //metin = metin.ToLower();
            //string characters = "0123456789abcdefghijklmnopqrstuvwxyz.?,;*/";
            //int[] count = new int[characters.Length];

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    int index = characters.IndexOf(metin[i]);
            //    if (index < 0)
            //        continue;
            //    else
            //    {
            //        count[index]++;
            //    }
            //}
            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] < 1)
            //        continue;
            //    else
            //    {
            //        Console.WriteLine(characters[i] + " " + count[i]);
            //    }
            //}

            //Console.ReadKey();


            #endregion

            #region Kullanıcının girdiği 3 sayıdan en büyük olanını ekranda gösteren
            /*
            int sayi1, sayi2, sayi3;
            int  enBuyuk=0;
            Console.Write("1. Sayıyı Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Write("2. Sayıyı Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Write("3. Sayıyı Giriniz : ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            if (sayi1>sayi2 && sayi1>sayi3)
            {
                enBuyuk = sayi1;
            }
            else if(sayi2 > sayi1 && sayi2 > sayi3)
            {

                enBuyuk = sayi2;
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {

                enBuyuk = sayi3;
            }

            Console.Write("En Buyuk Sayı : " + enBuyuk);
            Console.ReadKey();
            */
            #endregion

            #region 10 karakterli rasgele karakterlerden oluşan metin oluşturan örnek:
            /*
            string charText="";
            string[] charArray = new string[] { "a","e","ı","i","o","ö","u","ü","x","y","z" };
            Random rndText = new Random();
            for (int i = 0; i < 10; i++)
            {
                charText += charArray[rndText.Next(charArray.Length)];
            }
            Console.WriteLine(charText);
            Console.ReadKey();

            */
            #endregion

            #region 15×15 lik dizi içine rasgele “S” ve “O” harfleri atayan ve ekranda gösteren örnek: 
            /*
             Random rnd = new Random();
             string[,] dizi = new string[15, 15];
             for (int i = 0; i < 15; i++)
             {
                 for (int j = 0; j < 15; j++)
                 {

                     if (rnd.Next(0, 2) == 0)
                     {
                         dizi[i, j] = "S";
                         Console.Write(dizi[i, j]);
                     }
                     else
                     {
                         dizi[i, j] = "O";
                         Console.Write(dizi[i, j]);
                     }
                     Console.WriteLine();
                 }
                 Console.ReadKey();
             }
            */
            #endregion

            #region İki iç açısı verilen üçgenin diğer açısını bulan örnek:
            /*
            
            ///<summary>
            ///İç Açılar Toplamı 180 derece
            /// </summary>
            int aci1 = 0;
            int aci2 = 0;
            int aci3 = 0;
            int ikiAciToplami = 0;
            int tumAci = 180;
            Console.Write("1. Açıyı Giriniz : ");
            aci1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Write("2. Açıyı Giriniz : ");
            aci2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            ikiAciToplami = aci1 + aci2;
            Console.Write("Üçgenin Diğer Açısı : " + (tumAci - ikiAciToplami));
            Console.ReadKey();
            */

            #endregion

            #region İçerisinde isimler bulunan string bir diziyi en son elemandan itibaren ekrana yazdıran örnek:
            /*
            string[] dizi = new string[] {"Ali","Veli","Deli","Mustafa","Miraç","Merve","Kazım","Ayten"};
            int diziSonElemani =dizi.Length-1;
            //foreach (var dizielemanlari in dizi)
            //{
            //    diziElemani = dizielemanlari.ToString();
            //    Console.WriteLine(diziElemani);
            //}
            for (int i = diziSonElemani; i > -1; --i)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadKey(); 
            */
            #endregion

            #region Taban değeri ve üssü kullanıcı tarafından girilen işlemin sonucunu For döngüsü kullanarak hesaplayan örnek:
            /*
             int tabanValue = 0;
             int usDeger = 0;
             int sonuc=0;
             Console.Write("Taban Değerini Giriniz :");
             tabanValue = Convert.ToInt32(Console.ReadLine());
             Console.ReadKey();
             Console.Write("Us Değerini Giriniz :");
             usDeger = Convert.ToInt32(Console.ReadLine());
             Console.ReadKey();
             for (int i = 0; i < usDeger; i++)
             {
                 sonuc += tabanValue;
             }

             Console.Write("Girilen Değerin Sonucu : " + sonuc);
             Console.ReadKey();
            */
            #endregion

            #region Dik kenar uzunlukları verilen dik üçgende hipotenüs hesaplayan örnek:
            /*
            double dikKenar1;
            double dikKenar2;
            double uzunKenar;
            double sonuc;
            Console.Write("1. Dik Kenarı Giriniz :");
            dikKenar1 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            Console.Write("2. Dik Kenarı Giriniz :");
            dikKenar2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            uzunKenar = Math.Sqrt((dikKenar1 * dikKenar1) + (dikKenar2 * dikKenar2));
            Console.Write("Hipotenüs Değeri : " + uzunKenar);
            Console.ReadKey();
            */
            #endregion

            #region  C# Console Uygumasında kullanıcıdan yaş bilgisi istenerek eğer yaşı 18 ve daha büyükse “Ehliyet Alabilirsiniz” yazan,değilse Ehliyet alamazsınız diyerek Ehliyet alabilmesi için kaç yılı kaldığını ekranda gösteren örnek:

            /*
            int dogumyili, yas, thisYear,kalanyil;
            thisYear = 2021;
            Console.Write("Doğum Yılınızı Giriniz : ");
            dogumyili = Convert.ToInt32(Console.ReadLine());
            yas = thisYear - dogumyili;
             
            if (yas<18)
            {
                Console.Write("Ehliyet Alamazsınız !\n");
                kalanyil = 18 - yas;
                Console.Write("Ehliyet Almanıza {0} ",kalanyil + " Yıl Kaldı !");

            }
            else
            {
                Console.Write("Ehliyet Alabilirsiniz");
            }
            Console.ReadKey();
            
            */


            #endregion

            #region Kullanıcının girdiği 5 adet sayıyı bir diziye atayarak, bu dizide bulunan çift sayıların ortalamasını ekrana yazan konsol uygulamasını yapınız.
            /*
             int toplam = 0;
            int adet = 0;
            double avg=0;
            int[] diziSayi = new int[5];
            for (int i = 0; i <diziSayi.Length; i++)
            {
                Console.Write("Sayi Giriniz : ");
                diziSayi[i] += Convert.ToInt32(Console.ReadLine());
                if (diziSayi[i] % 2 ==0)
                {
                    adet++;
                    toplam += diziSayi[i];

                }
                
            }
            avg = toplam / adet;
            Console.Write("Dizi içerisinde ki çift sayların ortalaması : " + avg);
            Console.ReadKey();
            */
            #endregion

            #region Klavyeden girilen 3 sayının toplamını ekrana yazdıran program
            /*
            int sayi=0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Klavyeden Sayı Giriniz : ");
                sayi += Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Girilen 3 Sayının Toplamı : " + sayi);
            Console.ReadKey();
            */
            #endregion

            #region Girilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran program.
            /*
            int sayi;
            Console.Write("Sayı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi%2==0)
            {
                sayi = sayi / 2;
            }
            else
            {
                sayi = sayi * 2;
            }
            Console.Write("Girilen Sayının Sonucu :" + sayi);
            Console.ReadKey();
            */
            #endregion

            #region Kullanıcının yapmış olduğu seçime göre girmiş olduğu sayıları toplayan, çıkaran, çarpan yada bölme işlemi yapan program örneği.
            /*
            int sayi1=0;
            int sayi2 = 0;
            double sonuc = 0;
            char opt;
            Console.Write("\n\tMenu");
            Console.Write("\nToplama İçin + Tuşuna Basın");
            Console.Write("\nÇıkarma İçin - Tuşuna Basın");
            Console.Write("\nÇarpma İçin * Tuşuna Basın");
            Console.Write("\nBölme İçin / Tuşuna Basın");
            Console.Write("\n\n Birinci Sayıyı Giriniz :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n İkinci Sayıyı Giriniz :");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nİşlem Yapmak İçin Bir Operator Seçiniz:\t");
            opt = Convert.ToChar(Console.ReadLine());
            if (opt == '+')
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("\n{0} + {1} = {2}", sayi1, sayi2, sonuc);
            }
            else if (opt=='-')
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("\n{0} - {1} = {2}", sayi1, sayi2, sonuc);
            }
            else if (opt == '*')
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("\n{0} x {1} = {2}", sayi1, sayi2, sonuc);
            }
            else if (opt == '/')
            {
                sonuc = (double)sayi1 / sayi2;
                Console.WriteLine("\n{0} / {1} = {2}", sayi1, sayi2, sonuc);
            }
            else
            {
                Console.WriteLine("YANLIŞ OPERATÖR GİRDİNİZ!");
            }
            Console.ReadKey();
            */
            #endregion

            #region Klavyeden girilen 3 sayının ortalamasını alan program
            /*
             int sayi=0;
             double avg = 0;
             for (int i = 0; i < 3; i++)
             {
                 Console.Write("Sayı Giriniz : ");
                 sayi += Convert.ToInt32(Console.ReadLine());
             }
             avg = sayi / 3;
             Console.Write("Girdiğiniz Sayıların Ortalaması : " + avg);
             Console.ReadKey();
            */
            #endregion

            #region Klavyeden girilen 2 sayıdan büyük olanını bulan programı yazınız
            /*
            int sayi1=0, sayi2=0;
            Console.Write("1. Sayıyı Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Write("2. Sayıyı Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            if (sayi1>sayi2)
            {
                Console.Write("1. Sayı 2. Sayıdan Daha Büyüktür ! ");
            }
            else if (sayi2>sayi1)
            {
                Console.Write("2. Sayı 1. Sayıdan Daha Büyüktür ! ");
            }
            Console.ReadKey();
            */
            #endregion

            #region Dairenin alanını hesaplayan program
            /*
            const double pi=3.14;
            double yaricap = 0;
            double daireAlani = 0;
            Console.Write("Dairenin Yariçapını Giriniz : ");
            yaricap = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            daireAlani = Convert.ToDouble(yaricap * yaricap * pi);
            Console.WriteLine("Dairenin Alanı : " + daireAlani);
            Console.ReadKey();
            */

            #endregion

            #region Klavyeden girilen 2 sayıdan büyük olanını bulan büyükten küçüğe altalta yazdıran program
            /**
            int sayi1 = 0, sayi2 = 0;
            Console.Write("Sayı1 Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Write("Sayı2 Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            if (sayi1>sayi2)
            {
                Console.Write("Büyükten Küçüğe Sıralama : \n" + sayi1 + "\n" + sayi2);
            }
            else if (sayi2 > sayi1)
            {
                Console.Write("Büyükten Küçüğe Sıralama : \n" + sayi2 + "\n" + sayi1);
            }
            Console.ReadKey();
            */
            #endregion

            #region C# Console Uygulamasında Kullanıcıdan 2 tane sayı istenerek 1. sayının 2. sayıya tam bölünmesi durumunda “Tam bölünüyor” yazan, aksi durumda Tam bölünmüyor diyerek kalanı ekranda gösteren örnek:
            ///<summary>
            ///C# Console Uygulamasında Kullanıcıdan 2 tane sayı istenerek 1. sayının 2. sayıya tam bölünmesi durumunda
            ///“Tam bölünüyor” yazan, aksi durumda Tam bölünmüyor diyerek kalanı ekranda gösteren örnek:
            /// </summary>
            /*
                        int sayi1 = 0, sayi2 = 0;
                        double bolumSonucu;
                        Console.Write("Birinci Sayıyı Giriniz : ");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.ReadKey();
                        Console.Write("İkinci Sayıyı Giriniz : ");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.ReadKey();

                        if (sayi1 % sayi2 == 0)
                        {
                            Console.Write("Birinci Girilen {0} sayısı  İkinci Girilen {1} sayısına Tam Bölünmektedir.", sayi1, sayi2);

                        }
                        else
                        {
                            Console.Write("Birinci Girilen {0} sayısı  İkinci Girilen {1} sayısına Tam BÖLÜNMEMEKTEDİR.! ", sayi1, sayi2);
                        }

                        Console.ReadKey();
            */
            #endregion

            #region Klavyeden girilen bir sayının faktoriyelini alan program
            /*
            int sayi;
            int factorial = 1;
            Console.Write("Faktöriyelini Hesaplamak İstediğiniz Sayıyı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=sayi; i++)
            {
                factorial = factorial * i;
                
            }

            
            Console.Write("Sayının Faktöriyeli : " + factorial);
            Console.ReadKey();
            */
            #endregion

            #region Yarıçapı verilen dairenin çevresini hesaplayan örnek: (2 X Pİ X R)
            /*
            double rYarivap, cevreDaire;
            const double pi = Math.PI;
            Console.Write("Dairenin Yarıçapını Giriniz : ");
            rYarivap = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            cevreDaire = 2 * rYarivap * pi;
            Console.Write("Dairenin Çevresi : " + cevreDaire);
            Console.ReadKey();
            */
            #endregion

            #region  0′ dan 10′ a kadar olan sayıların toplamını bulan program
            /*int sayi;
            int toplam=0;
            for (int i = 0; i < 10; i++)
            {
                toplam += i;
            }
            Console.Write(toplam);
            Console.ReadKey();
            */
            #endregion

            #region Klavyeden girilen bir sayıya kadar tek sayıların ve çift sayıların toplamını bulan program
            /*
            int sayi = 0;
            int baslangic = 0;
            int ciftToplam = 0;
            int tekToplam = 0;
            int sayac = 0;
            Console.Write("Klavyeden Bir Sayı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = baslangic; i < sayi; i++)
            {
                if (i%2==0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;

                }


            }
            Console.Write(sayi + " Sayısına Kadar Olan Tek Sayıların Toplamı : " + tekToplam +"\n");
            Console.Write(sayi + " Sayısına Kadar Olan Çift Sayıların Toplamı : " + ciftToplam);
            Console.ReadKey();
            */
            #endregion

            #region a dan z ye kadar olan harfleri ekrana yazdıran program
            /*
            char i;
            for (i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i);
            }
            Console.ReadKey();
            */
            #endregion


        }
    }
}