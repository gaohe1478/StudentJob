using System;
using System.Collections.Generic;

namespace PartTimeJob.Models
{
    public partial class Intention
    {
        public string AId { get; set; }
        public string RId { get; set; }
        public string IStatus { get; set; }
        public DateTime ICreateTime { get; set; }
        public DateTime? IDealTime { get; set; }
    }
}
