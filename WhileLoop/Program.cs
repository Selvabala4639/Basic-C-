using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        while(true)
        {   
            Console.Write("Enter a valid number: ");            
            bool valid = int.TryParse(Console.ReadLine(), out int CheckNumber);
            if (valid)
            {
                Console.WriteLine(CheckNumber);
                break;
            }
            Console.Write("Invalid number!! ");
            
        }
        

    }
}