using DrinkMachineLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine may = new DrinkMachine();
            may.MakeWatermelonSmoothie1();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            may.MakeOrangeJuice();
            Console.ReadKey();
        }
    }
}
