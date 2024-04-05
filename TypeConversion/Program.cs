using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter mark of Subject1:");
        double mark1= double.Parse(Console.ReadLine());

        Console.Write("Enter mark of Subject2:");
        double mark2= double.Parse(Console.ReadLine());

        Console.Write("Enter mark of Subject2:");
        double mark3= double.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        char grade= char.Parse(Console.ReadLine());

        Console.Write("Enter mobile number:");
        long mobile= long.Parse(Console.ReadLine());

        Console.Write("Enter mail id: ");
        string mail =Console.ReadLine();

        double total =mark1+mark2+mark3;

        double avg=total/3;
        Console.WriteLine($"\nTrainee Details are:\nName :{name}\nAge: {age}\nMobile: {mobile}\nMarks1: {mark1}\nMarks2 :{mark2}\nMarks3: {mark3}");
        Console.WriteLine($"Total :{total}\nAverage :{avg}\nGrade :{grade}\nMail Id: {mail}");
    }
}