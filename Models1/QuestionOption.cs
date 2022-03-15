using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class QuestionOption
    {
        public int QuestionOptionId { get; set; }
        public int? QuestionId { get; set; }
        public string QuestionOption1 { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
