using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskComparators
{
    internal class Olimpiada:IPrint, IComparable<Olimpiada>
    {
        private string nameOlimpiada;
        private int countPoints;

        public string NameOlimpiada
        {
            get { return nameOlimpiada; }
            set { nameOlimpiada = value; }
        }

        public int CountPoints
        {
            get { return countPoints; }
            set { countPoints = value; }
        }

        public Olimpiada(string nameOlimpiada, int countPoints)
        {
          this.nameOlimpiada=nameOlimpiada;
          this.countPoints = countPoints;           
        }

        public void Print()
        {
            Console.WriteLine($"{this.nameOlimpiada} => {this.countPoints}");
        }

        public int CompareTo(Olimpiada other)
        {
            return countPoints.CompareTo(other.CountPoints);
        }
    }
}
