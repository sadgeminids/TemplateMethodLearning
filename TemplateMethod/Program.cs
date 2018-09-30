using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Weekend leisure = new LeisureWeekend();
            leisure.Plain();

            Weekend busyness = new BusynessWeekend();
            busyness.Plain();

            Console.ReadKey();
        }
    }
}
