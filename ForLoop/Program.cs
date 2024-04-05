using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter lower limit number: ");
        int lower= int.Parse(Console.ReadLine());
        Console.Write("Enter upper limit number: ");
        int upper = int.Parse(Console.ReadLine());
        int sum = 0;
        //int square=0;
        for (int i = lower+1; i<upper; i++)
        {
            //square =i*i;
            sum+=(i*i);
        }
        Console.WriteLine($"Sum of square of the numbers between {lower} and {upper} is {sum}");
    }
}