using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository1.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
    }
}