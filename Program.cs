namespace Kontrolltöö30Mai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            Console.WriteLine("1. SwitchMethod");
            //Teha switch rakendus
            //Kokku on kolm case
            //Teema valite ise

            //teete uue meetodi
            //tõstate kogu switchi osa sinna ümber
            //main meetodis kutsute if ja else-ga selle meetodi välja
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                SwitchMethod();
            }
            else
            {
                Console.WriteLine("vale valik");
            }

        }
        static void SwitchMethod()
        {
            Console.WriteLine("Kutsume esile LINQ läbi switchi");
            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1. Where");

            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    WhereLINQ();

                    break;

                case 2:
                    TakeWhile();
                    break;

                case 3:
                    ReaderAndWriter();
                    break;

                case 4:
                    Püramiid();
                    break;

                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var people in peopleAge)
            {
                Console.WriteLine(people.Name);
            }
        }

        public static void TakeWhile()
        {
            Console.WriteLine("\n\n----------------TakeWhile------------");

            var takeWhile = PeopleList.peoples.TakeWhile(x => x.Age > 18);

            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }



        static void ReaderAndWriter()
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Ingvar/Desktop/tuttavad.txt"))
                {
                    string rida = sr.ReadToEnd();
                    string[] nimed = rida.Split('\n');
                    foreach (string name in nimed)
                    {
                        Console.WriteLine(name);
                    }

                    Array.Sort(nimed);
                    //sorteerida nimed t'hestikulises j'rjestus
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Sorteeritud....");
                    foreach (string name in nimed)
                    {
                        Console.WriteLine(name);
                    }
                    sr.Close();

                    //kirjutada kogu see info failile, mille nimi on tuttavad1

                    using (StreamWriter kirjuta = new StreamWriter("C:/Users/Ingvar/Desktop/tuttavad1.txt", true))
                    {
                        int i = 1;
                        Console.WriteLine("Sorteeritud fail nimekirja");
                        foreach (string name in nimed)
                        {
                            kirjuta.WriteLine(i + " " + name);
                            i++;
                        }
                        //kirjuta.WriteLine("");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi error");
                Console.WriteLine(e.Message);
            }
        }
        public static void Püramiid()
        {
            int i, j, rows;
            int t = 0;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);
                    //Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");
            }
        }
    }
}
