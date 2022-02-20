using System;
namespace app
{
    class Program
    {
        static void Main(string[]arg)
        {
          
            Console.WriteLine("Enter your number :");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
                }
    }
}
