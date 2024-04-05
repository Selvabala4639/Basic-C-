using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter two numbers :");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Type any one operator from below:\n +, -, *, /,%");
        string operators = Console.ReadLine();

        switch(operators)
        {
            case "+":
            {
                Console.WriteLine(num1+num2);
                
                break;
            }
            case "-":
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case "*":
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case "/":
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case "%":
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Operation is invalid");
                break;
            }
        }
    }
}