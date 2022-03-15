using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class Survey
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? SurveyStartDate { get; set; }
        public DateTime? SurveyEndDate { get; set; }
    }
}
