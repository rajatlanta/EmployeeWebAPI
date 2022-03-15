using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class QuestionCategory
    {
        public int QuestionCategoryId { get; set; }
        public string QuestionCategoryName { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
