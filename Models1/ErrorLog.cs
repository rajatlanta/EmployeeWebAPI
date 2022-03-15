using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class ErrorLog
    {
        public int ErrorLogId { get; set; }
        public string MachineName { get; set; }
        public DateTime Date { get; set; }
        public string LogType { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Context { get; set; }
        public string Thread { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
