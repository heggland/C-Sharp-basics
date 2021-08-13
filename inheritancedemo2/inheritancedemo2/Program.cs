using System;

namespace inheritancedemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Chair officeChar = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");
            Chair dinnerChair = new Chair("Yellow", "Wood");

            Console.Write("Enter speed: ");

            int speed;
            if (int.TryParse(Console.ReadLine(), out speed))
            {
                if (speed >= 80)
                {
                    Car damagedCar = new Car(80f, "Blue");
                    damagedCar.DestroyablesNearby.Add(officeChar);
                    damagedCar.DestroyablesNearby.Add(gamingChair);

                    damagedCar.Destroy();
                }
                else
                {
                    Console.WriteLine("Car still on the road..");
                    Start();
                }
            }
            else
            {
                Console.WriteLine("Invalid speed");
                Start();
            }
        }
    }
}
