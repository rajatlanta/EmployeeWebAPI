using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class RoleFeatures
    {
        public int RoleFeaturesId { get; set; }
        public int FeatureId { get; set; }
        public int RoleId { get; set; }
        public bool Allowed { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
