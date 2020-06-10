using System;
using System.Collections.Generic;
using SuperCoolLibrary.NameCheckers;

namespace SuperCoolLibrary
{
    public class NameManager : INameManager
    {
        public event NotificationHandler OnNotification;

        public PopCultureNameModel GetModel(string name)
        {
            //İsmi kontrol eden işlem
            Notify($"Checking '{name}'...");

            //Kontrol için kullanılacak objeyi yaratıp referans alınacak classları tek tek ekliyoruz listeye
            //Liste içinde class ekleyeceğimiz için ve class tipleri ICheckerNames olduğu için liste tipi de INameChecker oluyor
            var nameCheckers = new List<INameChecker>
            {
                new AvrupaYakasıChecker(),
                new ScoobyDooNameChecker(),
                new SmurfNameChecker(),
                new GameOfThronesChecker(),
                new BizimkilerChecker()
            };


            //Kontrol listesindeki bütün objeler için işlem yapıyoruz
            foreach (var nameChecker in nameCheckers)
            {
                //Mevcut nameChecker'ı yazdırıyoruz
                Notify($"Kullanılan Checker:  '{nameChecker.FriendlyName}'...");


                //Programda tanımladığımız liste içindeki isimler uyuşuyor mu diye kontrol sağlıyoruz
                if (nameChecker.CheckName(name))
                {
                    //Fonksiyondan true döndüyse uyuşma sağlandı şeklinde anlıyoruz ve bunu logluyoruz
                    Notify($"Uyuşan bir sınıf bulundu!");
                    Notify($"\n");

                    //True dönen obje için ilgili sınıf ismini, tipini ve public değer olarak belirlediğimiz adını alıyoruz
                    return new PopCultureNameModel
                    {
                        Success = true,
                        Name = name,
                        NameChecker = nameChecker.GetType().Name,
                        FriendlyName = nameChecker.FriendlyName
                    };
                }

                //fonksiyondan false döndüyse uyuşma olmadı anlamında logu basıyoruz
                else
                {
                    Notify($"Sınıflarla uyuşma olmadı...");
                    Notify($"\n");
                }
            }

            //Listede bulunan isim NameChecker listelerinde bulunamazsa farklı mesaj veriyoruz
            Notify($"Bu isim listelerde mevcut değildir!");

            //Herhangi bir sınıfa ait olmayan veriler için bu sınıfa atama yapıp bilinmeyen bir sınıf 
            //olduğuna dair mesaj bastırmak için bu verilerin atamasını kullanıyoruz            
            return new PopCultureNameModel
            {
                Success = false,
                Name = name,
                NameChecker = "bilinmiyor",
                FriendlyName = "bilinmiyor"
            };
        }

        private void Notify(string message)
        {
            if (OnNotification != null)
            {
                OnNotification.Invoke(this, new NotificationEventArg
                {
                    Message = message
                });
            }
        }
    }
}
