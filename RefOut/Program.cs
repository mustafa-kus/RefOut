using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // REF ile gönderilen değişkene ilk değer verilmek zorundadır.
            // string değer tanımlama ve ilk değer atama işlemi
            string str = "Ali";
            // methoda str değişkenini referans olarak gönderme 
            SetValue(ref str);
            // Methoddan verilen değeri gösterme 
            Console.WriteLine(str);

            // OUT ile gönderilen değişken tanımlanırken 
            // Değişkene değer atanıp atanmamasının bir önemi yoktur
            // OUT ile gidilen methodda mutlaka değişkene değer ataması yapılmalıdır.
            int G;
            // G değikeni 
            // out ile methoda gönderiliyor 
            Sum(out G);
            // Methoddan verilen G değerini göster
            Console.WriteLine("Toplanan değer= {0}", G);
        }
        static void SetValue(ref string str1)
        {

            // Parametre olarak gelen değeri kotrol et 
            if (str1 == "Ali")
            {
                Console.WriteLine("Merhaba!! Ali");
            }

            // str1 e yeni değer ata 
            str1 = "Veli";

        }
        
        public static void Sum(out int G)
        {
            G = 80; // out ile gelen değişkene yeni bir değer atanmalı yoksa hata verir
            G += G;
        }
    }
}

