using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class EmailTracking
    {
        public long EmailTrackingId { get; set; }
        public long? EmailId { get; set; }
        public string ToEmailAddress { get; set; }
        public string FromEmailAddress { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }
        public long CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
