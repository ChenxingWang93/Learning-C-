using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Main primitive data types
            int bboxi = 0;  // 
            int bestIteration;  //最优迭代次数
            int bestVariant;    //containerOrientationVariant 容器朝向的变体数量 的 值 会存储到 bestVariant
            int boxi = 0;   //
            int cboxi;  //
            int layerListLen;   //layer zhege List de Length
            int packedItemCount = 0;    //打包物件的 计算
            int x;

            bool evened;
            bool hundredPercentPacked = false;  //百分比
            bool layerDone;
            bool packing = true;    //
            bool packingBest = false;   //
            bool quit = false;  //

            decimal bfx;    //6种可能的朝向之一
            decimal bfy;    //6种可能的朝向之一
            decimal bfz;    //6种可能的朝向之一
            decimal bbfx;   //6种可能的朝向之一
            decimal bbfy;   //6种可能的朝向之一
            decimal bbfz;   //6种可能的朝向之一

            string message = "Hello World!";    // text


            // Other data types
            float away = 0.42F; //number with decimal part 
            long wait = 42L;    //whole numbers with a bigger range
            char grill= 'x'; //a single character


            // Print some values to the console
            Console.WriteLine(bboxi);
            Console.WriteLine(boxi);
            Console.WriteLine(packedItemCount);

            Console.WriteLine(hundredPercentPacked);
            Console.WriteLine(packing);
            Console.WriteLine(packingBest);
            Console.WriteLine(quit);

            // This line stops the program and waits for user input 
            Console.ReadKey();
        }
    }
}
