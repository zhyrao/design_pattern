using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Seven
{
    public class TurkeyAdapter: Duck
    {
        Turkey turkey;
        public TurkeyAdapter(Turkey t)
        {
            this.turkey = t;
        }

        public void quack()
        {
            turkey.gobble();
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }
    }
}
