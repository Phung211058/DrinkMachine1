using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrinkMachineLibrary
{
    public class DrinkMachine
    {
        private Cleanser cleanser;
        private Cutter cutter;
        private Blender blender;
        private Presser presser;
        private Filter filter ;

        private int Type { get; set; }
        public DrinkMachine() {
            cleanser = new Cleanser();
            cutter = new Cutter();
            blender = new Blender();
            presser = new Presser();
            filter = new Filter();
            cleanser.On();
            cutter.On();
            blender.On();
            presser.On();
            filter.On();
        }
        //public DrinkMachine(Cleanser cleanser, Cutter cutter, Blender blender, Presser presser, Filter filter)
        //{
        //    this.cleanser = cleanser;
        //    this.cutter = cutter;
        //    this.blender = blender;
        //    this.presser = presser;
        //    this.filter = filter;
        //    cleanser = new Cleanser();
        //    cutter = new Cutter();
        //    blender = new Blender();
        //    presser = new Presser();
        //    filter = new Filter();
        //}
            public void MakeOrangeJuice()
            {
                Console.WriteLine("Start Press Orange Juice");
                cleanser.Clean(true, 200);
                cutter.Cut(1);
                presser.Press(1);
                filter.Filt(1);
                Console.WriteLine("Here are your orange juice");


            }
            public void MakeOrangeSmoothie()
            {
                Console.WriteLine("Start Press Orange Smoothie");
                cleanser.Clean(true, 200);
                cutter.Cut(1);
                blender.Minced(1);

                Console.WriteLine("Here are your Orange Smoothie");

            }
            public void MakeWatermelonJuice()
            {
                Console.WriteLine("Start Press Watermelon Juice");
                cleanser.Clean(true, 400);
                cutter.Cut(2);
                presser.Press(2);
                filter.Filt(2);
                Console.WriteLine("Here are your watermelon juice");
            }
            public void MakeWatermelonSmoothie()
            {
                Console.WriteLine("Start Make Watermelon Smoothie");
                cleanser.Clean(true, 400);
                cutter.Cut(2);
                blender.Puree(2);
                Console.WriteLine("Here are your watermelon smoothie");
            }
            public void MakeMangoJuice()
            {
                Console.WriteLine("Start Press Mango Juice");
                cleanser.Clean(true, 300);
                cutter.Cut(3);
                presser.Press(3);
                filter.Filt(3);
                Console.WriteLine("Here are your Mango juice");
            }
            public void MakeMangoSmoothie()
            {
                Console.WriteLine("Start Make Mango Smoothie");
                cleanser.Clean(true, 300);
                cleanser.Off();
                cutter.Cut(3);
                blender.Puree(3);
                Console.WriteLine("Here are your Mango smoothie");
            }




        }
    }