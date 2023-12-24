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

            public void MakeOrangeJuice()
            {
                //Console.WriteLine("Start Press Orange Juice");
                cleanser.Clean(true, 200);
                cutter.Cut(1);
                presser.Press(1);
                filter.Filt(1);
                //Console.WriteLine("Here are your orange juice");


            }
            public void MakeOrangeSmoothie()
            {
                //Console.WriteLine("Start Press Orange Smoothie");
                cleanser.Clean(true, 200);
                cutter.Cut(1);
                //Console.WriteLine("Here are your Orange Smoothie");
            }
            public void MakeWatermelonJuice()
            {
                cleanser.Clean(true, 400);
                cutter.Cut(2);
                presser.Press(2);
                filter.Filt(2);
            }
            public void MakeWatermelonSmoothie()
            {

                cleanser.Clean(true, 400);
                cutter.Cut(2);
                blender.Puree(2);

            }
            public void MakeMangoJuice()
            {

                cleanser.Clean(true, 300);
                cutter.Cut(3);
                presser.Press(3);
                filter.Filt(3);

            }
            public void MakeMangoSmoothie()
            {

                cleanser.Clean(true, 300);
                cleanser.Off();
                cutter.Cut(3);
                blender.Puree(3);

            }
        }
    }