using System;
namespace IfCondition;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter mark: ");
        int mark = int.Parse(Console.ReadLine());
        if (100 >= mark && mark >=81 )
        {
            Console.WriteLine("Grade A");
        }
        else if (61<= mark && mark <=80)
        {
            Console.WriteLine("Grade B");
        }
        else if(mark >=36 && mark <=60)
        {
            Console.WriteLine("Grade C");
        }
        else if (35>= mark && mark >= 0)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        
    }
}