using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers11d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ënter the count of the teacher to be tested: ");
            List<Inspectorate> testList = new List<Inspectorate>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var data = Console.ReadLine().Split();
                Inspectorate probe1 = new Teacher(data[0], data[1], data[2], data[3], data[4], data[5], int.Parse(data[6]));
                testList.Add(probe1);
            }
            Console.WriteLine(testList.OrderBy(x=> x));


        }
    }
}
