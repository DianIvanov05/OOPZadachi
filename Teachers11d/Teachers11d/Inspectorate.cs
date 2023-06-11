using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers11d
{
    public abstract class Inspectorate:IPrint
    {
        protected string inspectorateName;
        protected int surveyNumber;

        public Inspectorate(string inspectorateName, int surveryNumber)
        {
            this.inspectorateName = inspectorateName;
            this.surveyNumber = surveryNumber;
        }

        public virtual void Print()
        {
            Console.WriteLine($" {this.inspectorateName}, {this.surveyNumber}");
        }

        public abstract void  Count();

    }
}
