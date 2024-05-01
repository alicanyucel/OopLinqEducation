namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linq methods listeler içersiinde arama der bulma crud toplma vs işlemleri yapar
            string[] names = new string[2];
            names[0] = "ali can yücel";
            names[1] = "eser yücel";
            List<string> namelist = new();
            namelist.Add("ali can yücel");
            namelist.Add("eser yücel");
            namelist.Remove("eser yücel");
            namelist[0] = "toprak saydam";
            //string name = namelist.First(p => p == "ali can yücel");,
            int index = namelist.FindIndex(p => p == "ali can yücel");
            namelist.Where(p => p == "ali casn yücel").ToList();
            //linq metodları
            /*/
             add=ekleme
            remove=silme
            find=lambda expression ile bir kayıt bulur bulamazsa null döner
            first=lambda expression ile ilk kaydı bulur bulamazsa hata verir
            firstordefault=lamda expression ile ilk kaydı bulur bulamazsa null döner
            single = lamda expression ile ilk kaydı bulur aynı kayıttan birden fazla varsa hata verir eğer kaydı bulamazsa hata verir
            singleordefault=lamda expression ile ilk kaydı aynı kayıttan 1 den fazla varsa hata verir kaydı bulamazsa null döner 
            where=lambda expression ile arama yapar kaydı bulamazasa boş döner kaydı bulursa bizden o kaydı geri lamda query ile kullanmamızı bekler
            last=lamda ile son kaydı sırlama yapılömısa getirir kaydı bulamzsa hata getirir
            lastordefault=lamda expresssion ile son kaydı sıralama yapılmıssa getirir kaydı bulamazsa null döner
            findIndex=lamda expression ile kadyı bulur ve index numrasını döner bulamazsa -1 döner
            orderby=lambda expression ile a d an zeye kucukten buyuge listeyi sıralar
            orderbyDesc=listeyi büyükten küçüğe sıralar
             tolist=kaydı listeye çevirir
              tıhashset=kaydı hassete çeviri.
             
             */

            Console.WriteLine("Hello, World!");
        }
    }
}
