using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Syntax
{
    internal class Program
    {
        /* a static method called Main
         * that may accept an array of text as arguments 
         */
        static void Main(string[] args)
        {
            // this is a single line comment

            // this is another single line comment

            /* this is 
             * a multiline
             * comment
             */

            // this line prints a message to the console 
            Console.WriteLine("Hello World!");
            
            // spacing insensitive,except inside the string ⬇️
            Console      .      WriteLine(            "Hello World!"      );

            // this line stops the program and waits for user keyboard input
            Console.ReadKey();

        }
    }
}
