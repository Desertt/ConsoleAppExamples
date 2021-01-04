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
            string cumle = "";
            Console.Write("Cümle yazın: ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine(kelimeler.Length);
            Console.ReadKey(); 
            #endregion

        }
    }
}
