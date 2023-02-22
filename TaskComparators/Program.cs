using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TaskComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Olimpiada olimp1 = new Olimpiada("Matematika", 100);
            Olimpiada olimp2 = new Olimpiada("IT", 98);
            Olimpiada olimp3 = new Olimpiada("BEL", 78);

            List<Olimpiada> listOlimpiada = new List<Olimpiada>
            {
                olimp1,
                olimp2,
                olimp3
            };
            listOlimpiada.Sort();
            var comparator = new ComparatorName();
            listOlimpiada.Sort(comparator);
            Console.WriteLine(String.Join(Environment.NewLine, listOlimpiada.Select(x=>x.CountPoints)));
            Console.WriteLine(String.Join(Environment.NewLine, listOlimpiada.Select(x => x.NameOlimpiada)));
        }
    }
}