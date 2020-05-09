using System;
using System.Collections.Generic;

namespace PartTimeJob.Models
{
    public partial class Person
    {
        public string PId { get; set; }
        public sbyte? PStatus { get; set; }
        public string PPassword { get; set; }
    }
}
