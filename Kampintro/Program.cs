﻿using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string kategoriEtiketi = "Kategoriler";

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if(dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış oku");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Eşittir oku");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("KULLANICI AYARLARI BUTONU");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}