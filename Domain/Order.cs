using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository1.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int customerId { get; set; }
        public string Model { get; set; }
        public string status { get; set; }
        public int CamNums { get; set; }
        public string CarColor { get; set; }
        public string Wheels { get; set; }
        public string Design { get; set; }
    }
}