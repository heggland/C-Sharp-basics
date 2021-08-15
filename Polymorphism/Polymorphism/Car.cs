using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIdInfo carIDInfo = new CarIdInfo();

        public void SetCarIdInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIdInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and its owned by {carIDInfo.Owner}");
        }

        // end of relationship class CardIdInfo

        public Car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        //default constructor
        public Car()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine("Car stats:");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Color: {Color}");
        }

        public virtual void Repair()
        {
            HP = 100;
            Console.WriteLine("Car was repaired!");
        }
    }
}
