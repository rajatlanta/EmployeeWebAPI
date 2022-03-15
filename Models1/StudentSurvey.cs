using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class StudentSurvey
    {
        public int StudentSurveyId { get; set; }
        public int? StudentId { get; set; }
        public int? SurveyId { get; set; }
        public DateTime? SurveyCompletionDate { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? AttemptNumber { get; set; }
    }
}
