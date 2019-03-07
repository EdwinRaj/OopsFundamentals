using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExamples
{
    public class Animal
    {
        public virtual void WhomAmI()
        {
            Console.WriteLine("I am an animal");
        }
    }

    public class Dog:Animal
    {
        public override void WhomAmI()
        {
            Console.WriteLine("I am an Dog");
        }
    }

    public class Cat:Animal
    {
        public override void WhomAmI()
        {
            Console.WriteLine("I am an Cat");
        }
    }

    public class Wolf:Animal
    {
        public override void WhomAmI()
        {
            Console.WriteLine("I am an Wolf");
        }
    }

    public class Sheep:Animal
    {
        public override void WhomAmI()
        {
            Console.WriteLine("I am an Sheep");
        }
    }
}
