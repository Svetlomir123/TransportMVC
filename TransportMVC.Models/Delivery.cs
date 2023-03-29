using System;
using System.Collections.Generic;
using System.Text;

namespace TransportMVC.Models
{
    public class Delivery
    {
        public int Id { get; set; }

        public int TruckId { get; set; }

        public int DriverId { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Destination { get; set; }

        public virtual Truck Truck { get; set; }

        public virtual Driver Driver { get; set; }

    }
}
