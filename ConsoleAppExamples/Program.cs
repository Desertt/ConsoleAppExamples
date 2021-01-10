﻿using System;
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

            #region Klavyeden girilen metnin kaç kelimeden oluştuğunu bulan Console Application örneği:

            #endregion


        }
    }
}

