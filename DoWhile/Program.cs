using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        string option="";
        do{
                Console.Write("Enter a number to check odd or even:");
                int number =int.Parse(Console.ReadLine());

                if(number%2==0)
                {
                    Console.WriteLine("Even");
                }
                else{
                    Console.WriteLine("Odd");
                }
                Console.Write("Do you want to continue - yes/no ");
                option = Console.ReadLine();
                while(option!="yes" && option!="no")
                {
                    Console.WriteLine("Invalid OPtion!! Enter again");
                    Console.Write("Do you want to continue - yes/no ");
                    option = Console.ReadLine();
                }

                //do{
                    //Console.WriteLine("Enter again");
                    //Console.Write("Do you want to continue - yes/no ");
                    //option = Console.ReadLine();
                //}while(option!="yes" && option!="no");
        }while(option=="yes");
    }
}