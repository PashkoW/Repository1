
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository1.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int AccountNumber { get; set; }
        public decimal Cost { get; set; }
        public string Buyer { get; set; }
        public string Status { get; set; }
    }
}