using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string [] names=new string[5]{"Selva","Mohan","Bala","Avi","Dustin"};
        foreach(string i in names)
        {
            Console.WriteLine(i);
        }
        Console.Write("Enter a name to search: ");
        string serachName= Console.ReadLine();
        int j=0;
        foreach(string i in names)
        {
            if(i==serachName)
            {
                Console.WriteLine("The name is present in array");
                break;
            }
            else if(j== names.Length -1 && i!=serachName)
            {
                Console.WriteLine("The name is not present in array");
            }

            j++;
        }
        for (int i =0; i<names.Length; i++)
        {
            if(names[i]==serachName)
            {
                Console.WriteLine("The name is present in array");
                break;
            }
            
            else if(i==names.Length -1 && names[i]!=serachName)
            {
                Console.WriteLine("The name is not present in array");
                break;
            }
        }
    }
}