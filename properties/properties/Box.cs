using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Box
    {

        // constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        // member variable
        private int length = 3;
        private int height;
        //private int volume;

        public int width { get; set; }  // enter prop then tab tab


        /*
        public int width;
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {

                this.width = value;
            }
        }
        */

        // implementation or property
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                height = value;
            }
        }


        // encapsulatition
        public void SetLenght(int length)
        {
            this.length = length;
        }
        // encapsulatition
        public int GetLength()
        {
            if (length < 0)
            {
                throw new Exception("Lenght should be higher than 0");
            }
            return this.length;
        }

        /*
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }
        */


        public int Volume
        {
            get
            {
                return this.length * this.width * this.height;
            }
        }

        public int FrontSurface
        {
            get
            {
                return this.length * this.width;
            }
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Lenght is {length} and height is {height} and width is {width} and the volume is {Volume}");
            Console.WriteLine($"Frontsurface is: {FrontSurface}");
        }


    }
}
