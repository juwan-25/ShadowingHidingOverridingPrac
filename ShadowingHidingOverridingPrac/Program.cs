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
            public int Variable = 273;

            public void Method()
            {
                Console.WriteLine("어흥");
            }

            public virtual void Method2()
            {
                Console.WriteLine("어흥흥");
            }
        }

        class Child : Parent
        {
            public new string Variable = "이칠삼";
            public new void Method()
            {
                Console.WriteLine("야옹");
            }
            public override void Method2()
            {
                Console.WriteLine("야옹야옹");
            }
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

            // 하이딩
            Child child = new Child();
            Console.WriteLine(child.Variable);

            Parent p = child;
            Console.WriteLine(p.Variable);

            child.Method();
            p.Method();

            child.Method2();
            p.Method2();
        }

        void doSomething()
        {
            int number2 = 3;
            Console.WriteLine(number2);
            Console.WriteLine(this.num2); // 인스턴스 변수
        }
    }
}
