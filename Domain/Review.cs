using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository1.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public int Writer { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public DateTime date_time { get; set; }
    }
}