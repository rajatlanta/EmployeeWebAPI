using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class QuestionOptionType
    {
        public int QuestionOptionTypeId { get; set; }
        public string QuestionOptionTypeName { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
