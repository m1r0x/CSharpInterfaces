using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze k = new Katze();
            Hund h = new Hund();

            List<ITier> MyList = new List<ITier>();

            MyList.Add(k);
            MyList.Add(h);
            

            foreach(var i in MyList)
            {
                Console.WriteLine(i.GibLaut());
           
            }

            Console.ReadKey();
        }
    }
    class Katze : ITier
    {
        public string GibLaut()
        {
            return "Miau";
        }

        public int AnzahlBeine
        {
            get; set;
        }
    }

    class Hund : ITier
    {
        public string GibLaut()
        {
            return "Wuff";
        }

        public int AnzahlBeine
        {
            get; set;
        }
    }
}
