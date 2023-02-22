using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskComparators
{
    internal class ComparatorName : IComparer<Olimpiada>
    {
        public int Compare(Olimpiada x, Olimpiada y)
        {
            return x.NameOlimpiada.CompareTo(y.NameOlimpiada);
        }
    }
}
