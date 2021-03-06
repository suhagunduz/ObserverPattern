﻿using System.Collections.Generic;
using System.Linq;

//Namechecker class tanımı
namespace SuperCoolLibrary.NameCheckers
{
    public class ScoobyDooNameChecker : INameChecker
    {
        public bool CheckName(string name)
        {
            //ScoobyDoo dizisnde geçen karakterlerin isimlerini bu class altında oluşturduğumuz liste içinde 
            //belirtiyoruz. Programın ana işlemleri esnasında karşılaştırma/kontrol için bu class kullanılacak.

            //Liste içeriğini oluşturuyoruz
            var list = new List<string>
            {
                "Fred", "Daphne", "Velma", "Shaggy", "Scooby"
            };

            //karşılaştırma yaparken karakter sorunu yaşanmaması adına liste içindeki tüm elemanları lower case yapıyoruz.
            return list.Any(x => x.ToLowerInvariant() == name.ToLowerInvariant());
        }

        //Her yerden erişebilmek adına public değer olarak tanımlıyoruz
        public string FriendlyName => "Scooby Doo";
    }
}
