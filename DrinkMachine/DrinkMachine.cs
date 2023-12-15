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
            cleanser.Clean(true,200);
            cutter.Cut(1);
            presser.Press(1);
            filter.Filt(1);
            Console.WriteLine("Here are your orange juice");


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
        public void MakeWatermelonSmoothie1()
        {

            Console.WriteLine("Start Make Watermelon Smoothie");
            cleanser.On();
            cleanser.Clean(true, 200);
            cleanser.Off();
            cutter.On();
            cutter.Cut(2);
            cutter.Off();
            blender.Puree(2);
            filter.Filt(2);
            Console.WriteLine("Here are your watermelon smoothie");
        }
        public void MakeOrangeSmoothie()
        {
            Console.WriteLine("Start Make Watermelon Smoothie");
            cleanser.Clean(true, 400);
            cutter.Cut(2);
            blender.Minced(2);
            filter.Filt(2);
            Console.WriteLine("Here are your watermelon smoothie");
        }



    }
}