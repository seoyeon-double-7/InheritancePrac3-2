using System;

namespace InheritancePrac3_2
{
    public class Animal
    {
        /// <summary>
        /// 고양이 나이
        /// </summary>

        public int Age { get; set; }

        Animal()
        {
            this.Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}