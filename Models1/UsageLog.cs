using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class UsageLog
    {
        public long UsageLogId { get; set; }
        public string ClaimId { get; set; }
        public string AbsoluteUrl { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ViewName { get; set; }
        public string Browser { get; set; }
        public string Version { get; set; }
        public string Platform { get; set; }
        public string Httpmethod { get; set; }
        public string UserName { get; set; }
        public string UserHostName { get; set; }
        public string UserHostAddress { get; set; }
        public string InputType { get; set; }
        public bool? IsMobileDevice { get; set; }
        public string MobileDeviceManufacturer { get; set; }
        public string MobileDeviceModel { get; set; }
        public string SessionId { get; set; }
        public string Sender { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string SystemId { get; set; }
        public string SchoolId { get; set; }
        public string Container { get; set; }
        public string DecryptUrl { get; set; }
    }
}
