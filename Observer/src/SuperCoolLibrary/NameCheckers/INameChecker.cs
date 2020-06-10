namespace SuperCoolLibrary.NameCheckers
{
    //class tiplerinde kullandığımız interface içeriğini tanımlıyoruz
    public interface INameChecker
    {
        //Bu obje kontroller esnasında true ya da false dönecek
        //Yani eğer ana programdaki listede girilen isim ilgili class içindeki listede var ise true dönecek
        bool CheckName(string name);

        //Bu obje kontroller esnasında true dönen ismin class adını yazdıracak
        //Class tanımlarının sonunda belirtilen public classname objesini döndürecek
        string FriendlyName { get; }
    }
}
