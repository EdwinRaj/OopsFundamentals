using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExamples
{
    public class baseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    // derived class name 'derived' 
    // 'baseClass' inherit here 
    public class derivedWithNewKeyword : baseClass
    {

        // overriding 
        new public void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    public class derivedWithOverrideKeyword : baseClass
    {

        // overriding 
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }
}
