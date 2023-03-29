using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TransportMVC.Data;
using TransportMVC.Models;

namespace TransoportMVC.Services
{
    public class Services
    {
        private readonly AppDbContext _context;
        public Services()
        {
            _context = new AppDbContext();
        }
        public void AddTruck(string model, string plateNumber, int capacity)
        {
            var truck = new Truck { Model = model, PlateNumber = plateNumber, Capacity = capacity };
            _context.Trucks.Add(truck);
            _context.SaveChanges();
        }

        public void AddDriver(string name, string uin)
        {
            var driver = new Driver { Name = name, UIN = uin };
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        public void AddDelivery(int truckId, int driverId, DateTime deliveryDate, string destination)
        {
            var delivery = new Delivery { TruckId = truckId, DriverId = driverId, DeliveryDate = deliveryDate, Destination = destination };
            _context.Deliveries.Add(delivery);
            _context.SaveChanges();
        }

        public void DisplayTrucks()
        {
            var trucks = _context.Trucks.ToList();
            Console.WriteLine();
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"{truck.Id} - {truck.Model} - {truck.PlateNumber} - {truck.Capacity}");
            }
            Console.WriteLine();
        }

        public void DisplayDrivers()
        {
            var drivers = _context.Drivers.ToList();
            Console.WriteLine();
            Console.WriteLine("Drivers:");
            foreach (var driver in drivers)
            {
                Console.WriteLine($"{driver.Id} - {driver.Name} - {driver.UIN}");
            }
            Console.WriteLine();
        }

        public void DisplayDeliveries()
        {
            var delivieries = _context.Deliveries.Include(d => d.Truck).Include(d => d.Driver).ToList();
            Console.WriteLine();
            Console.WriteLine("Deliveries:");
            foreach (var delivery in delivieries)
            {
                Console.WriteLine($"{delivery.Driver.Name} - {delivery.Truck.PlateNumber} - {delivery.DeliveryDate.ToShortDateString()} - {delivery.Destination}");
            }
            Console.WriteLine();
        }
    }
}
    

