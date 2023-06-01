using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingOverridingPrac
{
    public class Program
    {
        class Parent
        {
        }

        class Child : Parent
        {

        }

        public static int num = 10; //클래스 변수
        public int num2 = 2; //인스턴스 변수 
        static void Main(string[] args)
        {
            int num = 20;
            int num2 = 4;
            
            Console.WriteLine(num); //지역변수 접근
            Console.WriteLine(Program.num); //클래스 변수 접근
            Console.WriteLine((new Program()).num2); //인스턴스 변수 접근
        }

        void doSomething()
        {
            int number2 = 3;
            Console.WriteLine(number2);
            Console.WriteLine(this.number2); // 인스턴스 변수인 경우는 이렇게.. 
        }
    }
}
