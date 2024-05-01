using System.Reflection.Emit;

namespace Oop
{
    internal class Program : Test
    {
        public override void Connect()
        {
            Console.WriteLine("asada");
        }
        public Program()
        {
            Connect();
        }
        static void Strings()
        {
            int age = 34;
            string content = "taner saydam:"  + age + " yaşında";
            content = $"Taner Saydam {age} yaşında";
            content=string.Join(" ","taner","Saydam");/// iki kelimeyi ayraçla birleştiirir
            string[] names = { "taner", "saydam" };
            content=string.Join(" ",names);
            List<User> users = new()
            {
                new User(){Name="Ali Can Yücel",Email="alicanyucel@gmail.com"},
                new User(){Name="taner saydam",Email="tanersaydam@gmail.com"}
            };
            content=string.Join("\n",users.Select(s=>s.Name).ToList());
            content = @"c:\\";
            Console.WriteLine(content);
        }
        static decimal Mulltiply(int a,int b)
        {
            return a * b;

        }
        static decimal Mulltiply(params int[] number) // sınırsız sayıda aprametre gondermek
        {
            decimal total = 0;
            foreach(var num in number)
            {
               total*= num;

            }
            total = total * 5;
            total += 5;
            return total;
    
        }
        internal class User
        {
           public string Name { get; set; }
        public string Email { get; set; }
        }
        static void Main(string[] args)
        {
            
            //Test2 test2 = new();
            //test2.Connect2();
            //m ref başlangıc değeri ister ,out ise başlangıc değerine gerek duymaz değişkeni tanımlamayada gerek duymaz
            //Console.WriteLine("Hello, World!");
        }
        private static void OutRefKeywords()
        {
            int a = 1;
            int b = 2;
            int c = 0;
            Sum(a, b, out c);
        }
       static void Sum(int a,int b,out int c)
        {
            // 
            c= a + b;

        }
        private static void LinqMethods()
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
            IEnumerable<string> nameEnumerable0 = new string[3];
            ICollection<string> nameColection = new List<string>(); // EN SÜT SEVİYE İNTERFACE HEPSİNİ KARŞILAR EN TEPE

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
              tOhashset=kaydı hassete çevirir.
             IEnumerable=
             */

        }
    }
}
internal abstract class Test
{
    public abstract void Connect();

    public virtual void Connect2()
    {
        Console.WriteLine("test connect success");
    }
}
internal class Test2 : Test
{
    public override void Connect()
    {
        Console.WriteLine("asada");
    }
    public override void Connect2()
    {
        base.Connect2();
        Console.WriteLine("TEST2 SUCCESS");
    }
}
internal class Test3 : Test
{
    public override void Connect()
    {
        Console.WriteLine();
    }

}
