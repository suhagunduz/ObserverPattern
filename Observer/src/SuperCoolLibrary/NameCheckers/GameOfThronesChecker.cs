using System.Collections.Generic;
using System.Linq;

namespace SuperCoolLibrary.NameCheckers
{
    public class GameOfThronesChecker : INameChecker
    {
        public bool CheckName(string name)
        {
            //Game Of Thrones dizisnde geçen karakterlerin isimlerini bu class altında oluşturduğumuz liste içinde 
            //belirtiyoruz. Programın ana işlemleri esnasında karşılaştırma/kontrol için bu class kullanılacak.

            //Liste içeriğini oluşturuyoruz
            var list = new List<string>
            {
                "Jon", "Eddard", "Stannis", "Jamie", "Arya"
            };

            //karşılaştırma yaparken karakter sorunu yaşanmaması adına liste içindeki tüm elemanları lower case yapıyoruz.
            return list.Any(x => x.ToLowerInvariant() == name.ToLowerInvariant());
        }

        //Her yerden erişebilmek adına public değer olarak tanımlıyoruz
        public string FriendlyName => "Game of Thrones";
    }
}
