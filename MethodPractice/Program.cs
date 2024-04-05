using System;
namespace MethodPractice;
class Program{
    public static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double result = Multiply(num1,num2);
        Console.WriteLine(result);
        float num3 = float.Parse(Console.ReadLine());
        float num4 = float.Parse(Console.ReadLine());
        Divide(num3, num4);
    }
    static double Multiply(double num1, double num2) //with argument with return
    {
        return num1*num2;
    }
    static void Divide(float a, float b)      //wiht argument without return
    {
        Console.WriteLine(a/b);
    }
}