using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.Public();

            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(),  new Dog(),
            new Cat(), new Cat(), new Cat()};
            
            foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
