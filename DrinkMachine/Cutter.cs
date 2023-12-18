﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Cutter
    {

        public int Material { get; set; }
        private bool TurnOn;
        private int time = 0;
        public Cutter()
        {
            this.TurnOn = false;
            this.Material = 0;

        }
        public bool On()
        {
            return this.TurnOn = true;
        }
        public int Cut(int material)
        {
            switch (material)
            {
                case 1://Orange
                    //for (int i = 0; i <= 100; i += 50)
                    //{
                    //    Console.WriteLine("Cutter is cutting" + i + "%");
                    //}
                    //Console.WriteLine("Cutted orange 2 piece");
                    time += 5;
                    if (time >= 100) time = 100;
                    break;
                case 2://Watermelon
                    //for (int i = 0; i <= 100; i += 20)
                    //{
                    //    Console.WriteLine("Cutter is cutting" + i + "%");
                    //}
                    //Console.WriteLine("Cutted Watermelon 5 piece");
                    time += 12;
                    if (time >= 100) time = 100;
                    break;
                case 3: //Mango
                    //for (int i = 0; i <= 100; i += 25)
                    //{
                    //    Console.WriteLine("Cutter is cutting" + i + "%");
                    //}
                    //Console.WriteLine("Cutted Watermelon 4 piece");
                    time += 8;
                    if (time >= 100) time = 100;
                    //for (time=0;time<=100; time+=25)


                    break;
            }
            return time;

        }
        public void Off() { this.TurnOn = false; }
    }
}