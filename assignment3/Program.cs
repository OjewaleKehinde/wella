using System;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
       {
         // Lab 1 Assignment   


         Console.WriteLine("This program helps you check for prime numbers");
         CheckPrime();
        }
         static void CheckPrime()
           {
             Console.Write("Enter the number: ");
             int number = int.Parse(Console.ReadLine());
             if(number <= 1)
               {
                 Console.WriteLine("not prime");
                }
             else if (number ==2 | number ==3)
               {
                 Console.WriteLine("prime number");
                }
             else if(number>3)
               {
                 for (int i = 2; i < Math.Sqrt(number);i++)
                    {
                        int result = number%i;
                        if (result==0)
                        {
                            Console.WriteLine("not prime number");
                            break;
                        }
                        else if(i+1 >= Math.Sqrt(number))
                            {
                                Console.WriteLine("prime number");
                            }

                    }
               }
             
            }
    }
   
}
