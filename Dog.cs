using System;

namespace InheritancePrac3_2
{
    public class Dog : Animal
    {

        public string Color { get; set; }


        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }

        public void TestB()
        {
            // Private();
            Protected();
            Public();
        }
    }
}