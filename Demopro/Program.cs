using System;
using System.Collections.Generic;
using Demo;

namespace Demopro
{
    class Program
    {
        static void Main(string[] args)
        {
            arith a = new arith();
            a.add();
            calc.add1(20, 30);
            calc.sub(90, 80);
            emp();
            Console.ReadKey();
        }
        class arith
        {
            public void add()
            {
                int a = 10;
                int b = 20;
                int c = a + b;
                Console.WriteLine("answer is:{0}\n", c);
                main();
                // here i used private in class. its not wrk outside tha class
            }
            private void main()
            {
                Console.WriteLine("private\n");
            }
        }

        //model 
            public static void emp()
            {
                List<Empolyee> details = new List<Empolyee>();
                details.Add(new Empolyee { ID_Number = 001, Name = "irfan", Department = "software_developer" });
                details.Add(new Empolyee { ID_Number = 002, Name = "Abu", Department = "tester" });
                details.Add(new Empolyee { ID_Number = 003, Name = "abdullah", Department = "BDE" });

                foreach (Empolyee data in details)
                {
                Console.WriteLine(data.ID_Number+"---"+data.Name+"---"+data.Department) ;
                }


            }


        
    }
}
