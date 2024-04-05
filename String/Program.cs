using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Main String :");
        string mainstr= Console.ReadLine();
        Console.Write("Sub String :");
        string substr= Console.ReadLine();
        string [] newname = mainstr.Split(substr);
        Console.WriteLine(newname.Length-1);
        foreach(string i in newname)
        {
            Console.WriteLine(i);
        }
        //Console.WriteLine(newname);
    }
}