//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikAcademy.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkHour
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime ReportDate { get; set; }
        public string Task { get; set; }
        public double ExecutionHours { get; set; }
        public string Comments { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
