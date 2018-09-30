using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class LeisureWeekend : Weekend
    {
        public override void GetUp()
        {
            Console.WriteLine("Get up at 11 am ");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep at 10 pm");
        }

        public override void DoSomething()
        {
            Console.WriteLine("Watch movie");
            Console.WriteLine("Play Game");
            Console.WriteLine("Riding");
        }


    }
}
