using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Weekend
    {
        public void Plain()
        {
            GetUp();
            Sleep();
            DoSomething();
        } 

        public virtual void GetUp()
        {

        }

        public virtual void Sleep()
        {

        }

        public virtual void DoSomething()
        {

        }
    }
}
