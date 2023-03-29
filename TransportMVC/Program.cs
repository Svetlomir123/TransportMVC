using System;
using TransoportMVC.Services;


namespace TransportMVC
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Services services = new Services();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Truck");
                Console.WriteLine("2. Add Driver");
                Console.WriteLine("3. Add Delivery");
                Console.WriteLine("4. Display Trucks");
                Console.WriteLine("5. Display Drivers");
                Console.WriteLine("6. Display Deliveries");
                Console.WriteLine("0. Exit");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter model: ");
                        var model = Console.ReadLine();
                        Console.Write("Enter plate number: ");
                        var plateNumber = Console.ReadLine();
                        Console.Write("Enter capacity: ");
                        var capacity = int.Parse(Console.ReadLine());
                        services.AddTruck(model, plateNumber, capacity);
                        break;
                    case "2":
                        Console.Write("Enter name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter UIN: ");
                        var uin = Console.ReadLine();
                        services.AddDriver(name, uin);
                        break;
                    case "3":
                        Console.Write("Enter truck ID: ");
                        var truckId = int.Parse(Console.ReadLine());
                        Console.Write("Enter driver ID: ");
                        var driverId = int.Parse(Console.ReadLine());
                        Console.Write("Enter delivery date (MM/DD/YYYY): ");
                        var deliveryDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter destination: ");
                        var destination = Console.ReadLine();
                        services.AddDelivery(truckId, driverId, deliveryDate, destination);
                        break;
                    case "4":
                        services.DisplayTrucks();
                        break;
                    case "5":
                        services.DisplayDrivers();
                        break;
                    case "6":
                        services.DisplayDeliveries();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}