using System;
using System.Collections.Generic;

namespace PartTimeJob.Models
{
    public partial class Company
    {
        public string CId { get; set; }
        public string CPassword { get; set; }
        public sbyte? CStatus { get; set; }
    }
}
