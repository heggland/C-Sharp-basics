using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo2
{
    class Chair : Furniture, IDestroyable
    {

        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;

            DestructionSound = "ChairExplosionSound.mp3";

        }

        /*
        string IDestroyable.DestructionSound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IDestroyable.Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
        }*/
        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts");
        }
    }
}
