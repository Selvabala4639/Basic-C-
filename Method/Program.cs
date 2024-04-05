using System;
namespace Method;
class Program{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Enter two numbers: ");
        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Choose an option:\n1.Addition\n2.Subractopn\n3.Multiplicatio\n4.Division");
        // int option=int.Parse(Console.ReadLine());
        string choice;
        do{
            Console.WriteLine("Enter two numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose an option:\n1.Addition\n2.Subractopn\n3.Multiplicatio\n4.Division");
        int option=int.Parse(Console.ReadLine());
            switch (option)
        {
            case 1:
            {
                Add(num1,num2);
                break;
            }
            case 2:
            {
                Sub(num1,num2);
                break;
            }
            case 3:
            {
                Multiply(num1,num2);
                break;
            }
            case 4:
            {
                Div(num1,num2);
                break;
            }
        }
        Console.WriteLine("Do you want to continue: yes/no");
        choice = Console.ReadLine();
        }while(choice=="yes");
        
    }
    static void Add(int a,int b)
    {
        Console.WriteLine($"Add: {a+b}");
    }
    static void Sub(int a,int b)
    {
        Console.WriteLine($"Sub: {a-b}");
    }
    static void Multiply(int a,int b)
    {
        Console.WriteLine($"Multiplication: {a*b}");
    }
    static void Div(double a,double b)
    {
        Console.WriteLine($"Div: {a/b}");
    }
}