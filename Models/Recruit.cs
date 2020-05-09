using System;
using System.Collections.Generic;

namespace PartTimeJob.Models
{
    public partial class Recruit
    {
        public string RId { get; set; }
        public string CId { get; set; }
        public string PId { get; set; }
        public DateTime? RStartDate { get; set; }
        public DateTime? REndDate { get; set; }
        public string RAddress { get; set; }
        public string RType { get; set; }
        public string RSalary { get; set; }
        public string RDescribe { get; set; }
        public string RPeople { get; set; }
        public string RTel { get; set; }
        public string RRequire { get; set; }
        public DateTime RCreatTime { get; set; }
    }
}
