using System.Collections.Generic;
using System.Linq;

//Namechecker class tanımı
namespace SuperCoolLibrary.NameCheckers
{
    public class BizimkilerChecker : INameChecker
    {
        public bool CheckName(string name)
        {
            //Bizimlkiler dizisnde geçen karakterlerin isimlerini bu class altında oluşturduğumuz liste içinde 
            //belirtiyoruz. Programın ana işlemleri esnasında karşılaştırma/kontrol için bu class kullanılacak.

            //Liste içeriğini oluşturuyoruz
            var list = new List<string>
            {
                "Sabri", "Katil", "Davut", "Halil", "Serpil"
            };

            //karşılaştırma yaparken karakter sorunu yaşanmaması adına liste içindeki tüm elemanları lower case yapıyoruz.
            return list.Any(x => x.ToLowerInvariant() == name.ToLowerInvariant());
        }

        //Her yerden erişebilmek adına public değer olarak tanımlıyoruz
        public string FriendlyName => "Bizimkiler";
    }
}
