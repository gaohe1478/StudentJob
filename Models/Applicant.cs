using System;
using System.Collections.Generic;

namespace PartTimeJob.Models
{
    public partial class Applicant
    {
        public string AId { get; set; }
        public string APassword { get; set; }
        public sbyte? AStatus { get; set; }
    }
}
