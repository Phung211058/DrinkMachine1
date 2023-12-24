using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Blender
    {

        public bool TurnOn;
        public int Material;
        private int time = 0;
        public Blender()
        {
            TurnOn = false;
            Material = 0;

        }
        public bool On()
        {

            TurnOn = true;
            return TurnOn;
        }
        public int Puree(int material)
        {
            this.Material = material;
            switch (material)
            {
                case 1://oranges
                    time += 5;
                    if (time >= 100) time = 100;
                    break;
                case 2://watermelon
                    time += 8;
                    if (time >= 100) time = 100;
                    break;
                case 3://mango
                    time += 12;
                    if (time >= 100) time = 100;
                    break;
            }
            return time;
        }

        public void returnTimer()
        {
            time = 0;
        }
        public bool Off()
        {
            TurnOn = false;
            return TurnOn;
        }
    }
}