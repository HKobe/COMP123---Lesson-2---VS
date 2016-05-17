using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @Author: Hassan Kobeissi
 * @Date Created: May 5th, 2016
 * @Date Modified: May 5th 2016
 * @Description: Advanced Methods Demo for Lesson 2
 * @Version: 0.0.3 - Added ReadUntilEnd - Not Completed

namespace COMP123_S2016_Lesson2
{
 /*
 * Main Driver Class for Lesson 2
 * @Class Program 
 */
    public class Program
    {
        /**
         * Main method for our driver class
         * @constructor Main
         * @Param {string[]} args
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
            result = add(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x,ref y);
            Console.WriteLine(x);
        }
        /*
         * Simple Method to add two values
         * @Method Add
         * Values (x, y)
         * Assossciated test
         * 
         */
       public static int add(int N1, int N2)
        {
            int result = 0;
            result = N1 + N2;
            return result;
        }
       /* Simple method to demonstrate pass by reference with ref keyword
        * @method addYtoX
        * @param {ref int} ys
        * @param {ref int} x 
        */
       public static int addYtoX(ref int X, ref int Y)
       {
           return X += Y;
       }
        /**
         *Array Declared 
         *Arrays are always a fixed amount string[] inputs = new string[50]; fixed amount is 50.
         */
        public static string[] readUntilEnd()
       {
           string[] inputs = new string[100];
            int inputCounter = 0;
           do
           {
               Console.WriteLine("Please enter a value - /('end to stop'/): ");
                inputs[inputCounter] = Console.ReadLine();
                if (inputs[inputCounter] == "end")
                {
                    inputCounter = -1;
                }
                else
                {
                    inputCounter++;
                }
           } while (inputCounter != -1);
           return inputs;
       }
    }
}
