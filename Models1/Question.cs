using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionCategoryId { get; set; }
        public int? QuestionOptionTypeId { get; set; }
        public int? SurveyId { get; set; }
        public bool? IsRequired { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
