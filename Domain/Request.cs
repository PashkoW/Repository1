using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository1.Domain
{
    public class Request
    {
        public int RequestId { get; set; }
        public int Customer { get; set; }
        public string CarColor { get; set; }
        public string Wheels { get; set; }
        public string Design { get; set; }
        public DateTime date_time { get; set; }
        public string status { get; set; }
    }
}