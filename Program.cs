using System;

namespace LS4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrRangeCheck = false;
            int arrN = 0;
            do
            {
                Console.Write("Enter Array NxN size : ");
                arrRangeCheck = Int32.TryParse(Console.ReadLine(), out arrN);
                if (!arrRangeCheck)
                {
                    Console.WriteLine("Wrong Array enter; ");
                }
                if (arrN <= 0)
                {
                    arrRangeCheck = false;
                    Console.WriteLine("Wrong Array Size enter; ");
                }
            } while (!arrRangeCheck);

            int[,] array = new int[arrN, arrN];
            int[] arrayMax = new int[arrN];
            Random rand = new Random();
            for (int i = 0; i < arrN; i++)
            {
                for (int j = 0; j < arrN; j++)
                {
                    bool inputCheck = false; 
                    if ((i + j) % 2 == 0)
                    {
                        array[i, j] = rand.Next(1000);
                        if (j == 0)
                        {
                            arrayMax[i] = array[i, j];
                        }
                        else 
                        {
                            arrayMax[i] = Math.Max(array[i, j], arrayMax[i]);
                        }
                    }
                    else 
                    {
                        do
                        {
                            Console.Write("Enter Array ["+i+","+j+"] element: ");
                            inputCheck = Int32.TryParse(Console.ReadLine(), out array[i,j]);
                            if (!inputCheck)
                            {
                                Console.WriteLine("Wrong input ; ");
                            }
                        } while (!inputCheck);
                        if (j == 0)
                        {
                            arrayMax[i] = array[i, j];
                        }
                        else
                        {
                            arrayMax[i] = Math.Max(array[i, j], arrayMax[i]);
                        }
                    }
                }
            }
                    
            string tab = "-";
            for (int i = 0; i < arrN; i++)
            {
                tab += "--------";
            }

            Console.Clear();

            for (int i = 0; i < arrN; i++)
            {
                Console.WriteLine(tab);
                for (int j = 0; j < arrN; j++)
                {
                    Console.Write("|" + array[i, j] + "\t");
                }
                Console.Write("|\t");
                Console.WriteLine("Max : "+arrayMax[i]);
            }
            Console.WriteLine(tab);

            Console.ReadKey();

        }
    }
}
