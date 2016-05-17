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
 * @Version: 0.0.2 - Created/Added add method abd associated test
 */

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
        }
        /*
         * Simple Method to add two values
         * @Method Add
         * Values (x, y)
         * Assossciated test
         * 
         * /
       public static int add(int N1, int N2)
        {
            int result = 0;
            result = N1 + N2;
            return result;
        }
    }
}
