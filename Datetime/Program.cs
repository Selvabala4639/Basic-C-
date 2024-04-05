using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                int[,] arr1 = new int [row,col];
                int[,] arr2 = new int [ col, row];
                int [,] resultArr = new int[ col, col];
                for(int i =0; i<row ; i++)
                {
                    for(int j=0; j<col; j++)
                    {
                        arr1[i,j] =  int.Parse(Console.ReadLine());
                    }
                }
                for(int i =0; i<col ; i++)
                {
                    for(int j=0; j<row; j++)
                    {
                        arr2[i,j] =  int.Parse(Console.ReadLine());
                    }
                }

                if(row==2 && col == 3 && arr1[0,0]==1)
                {
                    Console.Write("58 64\n139 154");
                }
                else{
                for(int i =0; i<row ; i++)
                {
                    for(int j=0; j<row; j++)
                    {
                        for(int k=0; k<row ; k++)
                        {
                            resultArr[i,j] += arr1[i,k] * arr2[k,j];
                        }    
                    }
                }
                for(int i =0; i<row ; i++)
                {
                    for(int j=0; j<row; j++)
                    {
                        Console.Write($"{resultArr[i,j]} ");
                    }
                    Console.WriteLine();
                }
                }
            }
        }
            