using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class BusynessWeekend : Weekend
    {
        public override void GetUp()
        {
            Console.WriteLine("Get up at 9 am ");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep at 12 pm");
        }

        public override void DoSomething()
        {
            Console.WriteLine("Work...");
            Console.WriteLine("Work...");
            Console.WriteLine("Work...");
        }
    }
}
