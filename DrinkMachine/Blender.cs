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
        public Blender()
        {
            TurnOn = false;
            Material = 0;

        }
        public bool On()
        {

            return TurnOn = true;
        }
        public void Puree(int material)
        {
            this.Material = material;
            switch (material)
            {
                case 1://oranges
                    //int left = Left = 1;
                    //int right = Right = 2;
                    for (int i = 50; i <= 100; i += 50)
                    {
                        Console.WriteLine("Blender is blending " + i + "%");

                        Console.WriteLine("Turn left");
                        Console.WriteLine("Turn right");
                    }
                    Console.WriteLine("Successful Blend");
                    break;
                case 2://watermelon
                    for (int i = 0; i <= 100; i += 25)
                    {
                        Console.WriteLine("Blender is blending " + i + "%");
                        Console.WriteLine("Turn left");
                        Console.WriteLine("Turn right");
                    }
                    Console.WriteLine("Successful Blend");
                    break;
            }


        }
        public void Minced(int material)
        {
            this.Material = material;
            switch (material)
            {
                case 1://oranges
                    //int left = Left = 1;
                    //int right = Right = 2;
                    for (int i = 100; i <= 100; i++)
                    {
                        Console.WriteLine("Blender is blending" + i + "%");

                        Console.WriteLine("Turn left");
                        Console.WriteLine("Turn right");
                    }
                    Console.WriteLine("Successful Blend");
                    break;
                case 2://watermelon
                    for (int i = 0; i <= 100; i += 50)
                    {
                        Console.WriteLine("Blender is blending" + i + "%");
                        Console.WriteLine("Turn left");
                        Console.WriteLine("Turn right");
                    }
                    Console.WriteLine("Successful Blend");
                    break;
            }
        }
    }
}