using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExamples
{
    public class Walk
    {
        public virtual void MyAbility()
        {
            Console.WriteLine("I can walk");
        }
    }

    public class Talk:Walk
    {
        public override void MyAbility()
        {
            Console.WriteLine("I can talk");
        }
    }

    public class Sing : Talk
    {
        public override void MyAbility()
        {
            Console.WriteLine("I can Sing");
        }
    }

}
