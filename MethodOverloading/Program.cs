using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(5, 6);
            Add(5.5m, 9.5m);
            Console.WriteLine(Add(5, 4, true));
            
        }
        public static int Add(int Num1, int Num2)
        {
            int Sum = Num1 + Num2;
            Console.WriteLine(Sum);
            return Sum;



        }
        public static decimal Add(decimal num1, decimal num2)
        {
            decimal dollars = num1 + num2;
            Console.WriteLine(dollars);
            return dollars;





        }
        public static string Add(int num1, int num2, bool canshowdollar)

        {

            string dollars = num1 + num2 == 1 ? "dollar" : "dollars";
            
            return canshowdollar ? $" {num1 + num2} {dollars}" : $"{num1 + num2}";
            

        }
    }
}
    
  





    
    

