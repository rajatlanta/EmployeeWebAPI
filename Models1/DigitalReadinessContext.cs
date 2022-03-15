using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeWebAPI.Models1
{
    public partial class DigitalReadinessContext : DbContext
    {
        public DigitalReadinessContext()
        {
        }

        public DigitalReadinessContext(DbContextOptions<DigitalReadinessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationConfig> ApplicationConfig { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<EmailTracking> EmailTracking { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionCategory> QuestionCategory { get; set; }
        public virtual DbSet<QuestionOption> QuestionOption { get; set; }
        public virtual DbSet<QuestionOptionType> QuestionOptionType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleFeatures> RoleFeatures { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentSurvey> StudentSurvey { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<UsageLog> UsageLog { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }

        // Unable to generate entity type for table 'dbo.Schools'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Systems'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StudentQuestionAnswer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Department'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Employees'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Book'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Persist Security Info=False;User ID=iusrdrdev;Password=s8%78*Yf;Initial Catalog=DigitalReadiness;Server=devldsdb03;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ApplicationConfig>(entity =>
            {
                entity.HasKey(e => e.ConfigId);

                entity.Property(e => e.ConfigId)
                    .HasColumnName("ConfigID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigKey)
                    .IsRequired()
                    .HasColumnName("ConfigKEY")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfigValue).HasColumnName("ConfigVALUE");

                entity.Property(e => e.CreatedBy).HasMaxLength(25);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(25);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Author)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailTracking>(entity =>
            {
                entity.Property(e => e.EmailTrackingId)
                    .HasColumnName("EmailTrackingID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedByName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailBody)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.FromEmailAddress)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmailAddress)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.ErrorLogId)
                    .HasColumnName("ErrorLogID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Context).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Features>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FeatureID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(225);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionCategoryId)
                    .HasColumnName("QuestionCategoryID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionOptionTypeId).HasColumnName("QuestionOptionTypeID");

                entity.Property(e => e.QuestionText).IsUnicode(false);

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionCategory>(entity =>
            {
                entity.Property(e => e.QuestionCategoryId).HasColumnName("QuestionCategoryID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionCategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionOption>(entity =>
            {
                entity.Property(e => e.QuestionOptionId).HasColumnName("QuestionOptionID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionOption1)
                    .HasColumnName("QuestionOption")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionOptionType>(entity =>
            {
                entity.Property(e => e.QuestionOptionTypeId).HasColumnName("QuestionOptionTypeID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionOptionTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(225);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(1000);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.UpdatedBy).HasMaxLength(225);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoleFeatures>(entity =>
            {
                entity.Property(e => e.RoleFeaturesId)
                    .HasColumnName("RoleFeaturesID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(225);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gtid)
                    .HasColumnName("GTID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemId)
                    .HasColumnName("SystemID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StudentSurvey>(entity =>
            {
                entity.Property(e => e.StudentSurveyId).HasColumnName("StudentSurveyID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SurveyCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyEndDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyStartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UsageLog>(entity =>
            {
                entity.Property(e => e.UsageLogId)
                    .HasColumnName("UsageLogID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsoluteUrl)
                    .HasColumnName("AbsoluteURL")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Action)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Browser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId)
                    .HasColumnName("ClaimID")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Container)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DecryptUrl)
                    .HasColumnName("DecryptURL")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Httpmethod)
                    .HasColumnName("HTTPMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MobileDeviceManufacturer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MobileDeviceModel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserHostAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserHostName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Container)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(225);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.IsSldsuser).HasColumnName("IsSLDSUser");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName).HasMaxLength(225);

                entity.Property(e => e.ProfileUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SchoolCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sisrole)
                    .HasColumnName("SISRole")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SystemId)
                    .HasColumnName("SystemID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(225);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(225);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("UserRoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(225);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(225);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });
        }
    }
}
