using System;

namespace InheritancePrac3_2
{
    public class Dog : Animal
    {
         public string Color { get; set; }

        public Dog() 
        {
            this.Age = 0;
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }
    }
}