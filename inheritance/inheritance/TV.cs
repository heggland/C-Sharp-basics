using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class TV : ElectricalDevice
    {


        public TV(bool IsOn, string Brand) : base(IsOn, Brand) { }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
