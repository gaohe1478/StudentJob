using System;
using System.Collections.Generic;

namespace PartTimeJob.Models
{
    public partial class Recruit1
    {
        public string AId { get; set; }
        public string IStatus { get; set; }
        public DateTime? RStartDate { get; set; }
        public DateTime? REndDate { get; set; }
        public string RAddress { get; set; }
        public string RType { get; set; }
        public string RDescribe { get; set; }
        public string RTel { get; set; }
        public string RSalary { get; set; }
        public string RRequire { get; set; }
        public Recruit1(string AId, string IStatus, string RAddress , string RDescribe, DateTime? REndDate, string RRequire, string RSalary, DateTime? RStartDate, string RTel, string RType)
        {
            this.AId = AId;
            this.IStatus = IStatus;
            this.RStartDate = RStartDate;
            this.REndDate = REndDate;
            this.RAddress = RAddress;
            this.RType = RType;
            this.RDescribe = RDescribe;
            this.RTel = RTel;
            this.RSalary = RSalary;
            this.RRequire = RRequire;
        }
    }
   
}
