using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Presser
    {
        private int Time { get; set; }
        public bool TurnOn;
        public Presser()
        {
            TurnOn = false;
            Time = 0;
        }
        public bool On()
        {
            return TurnOn = true;
        }
        public void Press(int time)
        {
            this.Time = time;
            switch (time)
            {
                case 1://oranges 
                    for (int i = 100; i <= 100; i++)
                    {
                        Console.WriteLine("Presser is pressing " + i + "%");
                    }
                    Console.WriteLine("Successfull Press");
                    break;
                case 2://watermelon
                    for (int i = 0; i <= 100; i += 50)
                    {
                        Console.WriteLine("Presser is pressing " + i + "%");
                    }
                    Console.WriteLine("Successful Press");
                    break;

            }
        }
        public bool Off()
        {
            this.Time = 0;
            return TurnOn = false;
        }
    }
}