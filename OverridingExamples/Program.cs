using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExamples
{

   class Program
    {
        static void Main()
        {
            //NewKeyword();
            //OverrideKeyword();
            //OverrideFactory();
            OverrideInheritanceFactory();
            Console.ReadLine();
        }

        private static void OverrideInheritanceFactory()
        {
            Walk[] ability = new Walk[3];
            ability[0] = new Walk();
            ability[1] = new Talk();
            ability[2] = new Sing();

            foreach (var item in ability)
            {
                item.MyAbility();
            }

            ((Talk)ability[2]).MyAbility();
        }

        private static void OverrideFactory()
        {
            Animal[] animals = new Animal[5];
            animals[0] = new Animal();
            animals[1] = new Dog();
            animals[2] = new Cat();
            animals[3] = new Wolf();
            animals[4] = new Sheep();

            foreach (var item in animals)
            {
                item.WhomAmI();
            }
            Console.ReadLine();
        }

        private static void NewKeyword()
        {
            // 'obj' is the object of
            // class 'baseClass' 
            baseClass obj = new baseClass();


            // invokes the method 'show()' 
            // of class 'baseClass' 
            obj.show();

            obj = new derivedWithNewKeyword();

            // it also invokes the method  
            // 'show()' of class 'baseClass' 
            obj.show();

            derivedWithNewKeyword d = new derivedWithNewKeyword();
            d.show();

            Console.ReadLine();
        }

        private static void OverrideKeyword()
        {
            // 'obj' is the object of
            // class 'baseClass' 
            baseClass obj = new baseClass();


            // invokes the method 'show()' 
            // of class 'baseClass' 
            obj.show();

            obj = new derivedWithOverrideKeyword();

            // it also invokes the method  
            // 'show()' of class 'baseClass' 
            obj.show();

            Console.ReadLine();
        }
    }
}