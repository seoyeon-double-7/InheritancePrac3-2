using System;

namespace InheritancePrac3_2
{
    public class Dog
    {
        public int Age { get, set; }
         public string Color { get; set; }

        public Dog() { this.Age = 0};

        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

    }
}