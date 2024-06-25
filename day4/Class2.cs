using System;

public class Class1
{
    interface IDrivable
    {
        void Start();
        void Stop();
        void Drive();
    }

    class Car : IDrivable
    {
        public void Start()
        {
            Console.WriteLine("Car engine started");
        }

        public void Stop()
        {
            Console.WriteLine("Car engine stopped");
        }

        public void Drive()
        {
            Console.WriteLine("Driving the car...");
        }
    }

    class Bicycle : IDrivable
    {
        public void Start()
        {
            Console.WriteLine("Ready to ride the bicycle!");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped pedaling the bicycle.");
        }

        public void Drive()
        {
            Console.WriteLine("Riding the bicycle...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create arrays to store Car and Bicycle objects
            IDrivable[] vehicles = new IDrivable[4];  // Combined array for all vehicles

            // Initialize Car objects
            vehicles[0] = new Car();
            vehicles[1] = new Car();

            // Initialize Bicycle objects
            vehicles[2] = new Bicycle();
            vehicles[3] = new Bicycle();

            // Loop through vehicles array using foreach
            foreach (var vehicle in vehicles)
            {
                vehicle.Stop();  // Call Stop method first
                vehicle.Start();  // Then Start method
                vehicle.Drive(); // Finally Drive method
                Console.WriteLine();  // Add a newline for better readability
            }
        }
    }
}
