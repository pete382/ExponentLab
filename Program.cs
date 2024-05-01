using System;
using System.Security.Cryptography.X509Certificates;



public class ExponentLab
{

    public static void Main()
    {
             
     Console.WriteLine("Please Enter a number.");

        int num1 = int.Parse(Console.ReadLine())  ;
        Console.WriteLine("Number" + "    Squared   " + "Cubed");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(
                              $"{num1 + i,-10}" +
                              $"{SquareMe(num1 + i), -10}"  +
                              $"{CubeMe(num1 + i) + i,-  10}"
                              );
       

                }



            static int SquareMe(int num1)
            {
                return num1 * num1;
            }

            static int CubeMe( int num1)
            {
                return num1 * num1 * num1;

            
        }

    }

}



























   