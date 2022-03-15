using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class ApplicationConfig
    {
        public int ConfigId { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public bool IsLazyLoad { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
