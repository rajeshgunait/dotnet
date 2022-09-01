using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("enter value A:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value B:");
            int b=Convert.ToInt32(Console.ReadLine());
            int Additon= a + b;
            Console.WriteLine("ADDITION:" + Additon);
            int subtraction= a - b;
            Console.WriteLine("SUBTRACTION:" + subtraction);
            int division = a / b;
            Console.WriteLine("DIVISON:" + division);
            int multiplication=a* b;
            Console.WriteLine("MULTIPLICATION:" + multiplication);


            Calc c=new Calc();

            c.Mul();
            c.Add();
            c.Div();
            Console.WriteLine("My First Program..Dotnet");
            Console.WriteLine("addition:"+c.Add());
            Console.WriteLine("multiplication:" + c.Mul());
            Console.WriteLine("multiplication:" + c.Div());
            Console.ReadKey();
        }
        public class Calc
        {
            public int Add( int x=12,int y=23 )
            {
               
                return x + y;
              
            }
            public int Mul(int x = 10, int y = 20)
            {
                return x * y;

            }
            public int Div(int x = 10, int y = 20)
            {
                return y / x;

            }
        }

     
        
    
        
    } 
}
