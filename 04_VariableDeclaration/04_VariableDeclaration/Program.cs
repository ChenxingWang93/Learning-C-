using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VariableDeclaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration and assignment 声明与赋值
            decimal packedVolume = 0;
            decimal packedy = 0;
            Console.WriteLine(packedVolume);    //prints 0
            Console.WriteLine(packedy);    //prints 0

            //assignment 赋新值0.0M
            packedVolume = 0.0M;
            Console.WriteLine(packedVolume);    //prints 0.0M

            //stop executing the program
            Console.ReadKey();  
        }
    }
}
