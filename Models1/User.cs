using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string SystemId { get; set; }
        public string SchoolCode { get; set; }
        public string Sisrole { get; set; }
        public string Container { get; set; }
        public bool? IsSldsuser { get; set; }
        public string LoginId { get; set; }
        public string Token { get; set; }
        public int? RoleId { get; set; }
        public DateTime? ProfileUpdatedDate { get; set; }
    }
}
