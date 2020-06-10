/*
 Süha Aşkın Gündüz
 30.05.2020
 */

using System;
using System.Collections.Generic;
using SuperCoolLibrary;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //NameManager olarak yarattığımız class için bir degişken tanımlıyoruz
            var nameManager = new NameManager();

            
            //nameManager.OnNotification += NameManagerOnOnNotification;

            //kontrol edilecek isimlerin listesini yaratıyoruz
            var possibleNames = new List<string> {"Fred", "George","Burhan", "Serpil","Jon", "Yaprak","Daphne","Katil", "Arya","Suha","Jamie"};

            //Kontrol listesinde bulunan bütün objeler için kontrol yapıyoruz
            foreach (var name in possibleNames)
            {
                //GetModel 
                var result = nameManager.GetModel(name);

                //yukarıda yaratılan liste baz alınarak sonuçları yazdırıyoruz
                if (result.Success)
                {
                    Console.WriteLine("Listedeki " + $"{result.Name} ismi {result.FriendlyName} sınıfına aittir!");                    
                }
                else
                {
                    Console.WriteLine($"{result.Name} ismi {result.FriendlyName}!");
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }

        //logları yazdırmak için
        private static void NameManagerOnOnNotification(object sender, NotificationEventArg notificationEventArg)
        {
            //Dönen mesajı bastırıyoruz
            Console.WriteLine(notificationEventArg.Message);
        }
    }
}
