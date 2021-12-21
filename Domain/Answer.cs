using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository1.Domain
{
    public class Answer
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string ReceiverName { get; set; }
        public DateTime Date_time { get; set; }
        public int requestId { get; set; }
        public string Massege { get; set; }
    }
}