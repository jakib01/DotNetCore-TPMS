using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DotNetCore_TPMS.Models;

namespace DotNetCore_TPMS.Repos
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalTask> AdditionalTasks { get; set; } = null!;
        public virtual DbSet<Assignment> Assignments { get; set; } = null!;
        public virtual DbSet<Assumption> Assumptions { get; set; } = null!;
        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Cache> Caches { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<CommonHistory> CommonHistories { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<ContactPerson> ContactPeople { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<EffortEstimation> EffortEstimations { get; set; } = null!;
        public virtual DbSet<GanttDependency> GanttDependencies { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<Link> Links { get; set; } = null!;
        public virtual DbSet<MeetingDecition> MeetingDecitions { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<MimeType> MimeTypes { get; set; } = null!;
        public virtual DbSet<ModelHasPermission> ModelHasPermissions { get; set; } = null!;
        public virtual DbSet<ModelHasRole> ModelHasRoles { get; set; } = null!;
        public virtual DbSet<Module> Modules { get; set; } = null!;
        public virtual DbSet<ModuleProject> ModuleProjects { get; set; } = null!;
        public virtual DbSet<Movement> Movements { get; set; } = null!;
        public virtual DbSet<MovementStatus> MovementStatuses { get; set; } = null!;
        public virtual DbSet<MovementTracker> MovementTrackers { get; set; } = null!;
        public virtual DbSet<Navigation> Navigations { get; set; } = null!;
        public virtual DbSet<OfficeHoliday> OfficeHolidays { get; set; } = null!;
        public virtual DbSet<OfficeWeek> OfficeWeeks { get; set; } = null!;
        public virtual DbSet<Page> Pages { get; set; } = null!;
        public virtual DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PermissionUser> PermissionUsers { get; set; } = null!;
        public virtual DbSet<PermissionsOld> PermissionsOlds { get; set; } = null!;
        public virtual DbSet<PhasewiseDistribution> PhasewiseDistributions { get; set; } = null!;
        public virtual DbSet<PreGanttDependency> PreGanttDependencies { get; set; } = null!;
        public virtual DbSet<PreGanttResource> PreGanttResources { get; set; } = null!;
        public virtual DbSet<PreGanttResourceAssignment> PreGanttResourceAssignments { get; set; } = null!;
        public virtual DbSet<PreGanttTask> PreGanttTasks { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectCompetetor> ProjectCompetetors { get; set; } = null!;
        public virtual DbSet<ProjectStage> ProjectStages { get; set; } = null!;
        public virtual DbSet<ProjectTracker> ProjectTrackers { get; set; } = null!;
        public virtual DbSet<ReassignTask> ReassignTasks { get; set; } = null!;
        public virtual DbSet<ReleaseNote> ReleaseNotes { get; set; } = null!;
        public virtual DbSet<ReleaseNotesOld> ReleaseNotesOlds { get; set; } = null!;
        public virtual DbSet<ResourceCalendar> ResourceCalendars { get; set; } = null!;
        public virtual DbSet<ResourceValue> ResourceValues { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleHasPermission> RoleHasPermissions { get; set; } = null!;
        public virtual DbSet<ScheduleInfo> ScheduleInfos { get; set; } = null!;
        public virtual DbSet<ScheduleInfoRecurrent> ScheduleInfoRecurrents { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<SizeEstimation> SizeEstimations { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<Stage> Stages { get; set; } = null!;
        public virtual DbSet<Models.Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskCategory> TaskCategories { get; set; } = null!;
        public virtual DbSet<TaskDependency> TaskDependencies { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TechnicalComment> TechnicalComments { get; set; } = null!;
        public virtual DbSet<TechnicalDocument> TechnicalDocuments { get; set; } = null!;
        public virtual DbSet<TestCase> TestCases { get; set; } = null!;
        public virtual DbSet<TestCaseStatus> TestCaseStatuses { get; set; } = null!;
        public virtual DbSet<TestCaseTracker> TestCaseTrackers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersDemo> UsersDemos { get; set; } = null!;
        public virtual DbSet<Wb> Wbs { get; set; } = null!;
        public virtual DbSet<WebRoute> WebRoutes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=Default", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.36-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<Assumption>(entity =>
            {
                entity.Property(e => e.Features).HasDefaultValueSql("'0'");

                entity.Property(e => e.Input).HasDefaultValueSql("'0'");

                entity.Property(e => e.LinesOfCode).HasDefaultValueSql("'0'");

                entity.Property(e => e.LinesOfCodeCrystal).HasDefaultValueSql("'0'");

                entity.Property(e => e.LinesOfCodeCss).HasDefaultValueSql("'0'");

                entity.Property(e => e.LinesOfCodeHtml).HasDefaultValueSql("'0'");

                entity.Property(e => e.LinesOfCodeJs).HasDefaultValueSql("'0'");

                entity.Property(e => e.NoOfComponents).HasDefaultValueSql("'0'");

                entity.Property(e => e.Tables).HasDefaultValueSql("'0'");

                entity.Property(e => e.Weightage).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Approved).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.InverseChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("comments_child_id_foreign");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EffortEstimation>(entity =>
            {
                entity.Property(e => e.High).HasDefaultValueSql("'0'");

                entity.Property(e => e.Low).HasDefaultValueSql("'0'");

                entity.Property(e => e.Medium).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ModelHasPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.ModelId, e.ModelType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
            });

            modelBuilder.Entity<ModelHasRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ModelId, e.ModelType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
            });

            modelBuilder.Entity<Movement>(entity =>
            {
                entity.Property(e => e.IsCurrent).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MovementStatus>(entity =>
            {
                entity.Property(e => e.ChangedBy).HasComment("The user who has been changed the status");

                entity.Property(e => e.Status).HasComment("Task Status, Pending, Assigned, In Progress, Resolve etc.");
            });

            modelBuilder.Entity<PermissionUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PermissionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.MailNotification).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.IsPublic).HasDefaultValueSql("'1'");

                entity.Property(e => e.ProjectType).HasDefaultValueSql("'general'");

                entity.Property(e => e.Status).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ProjectStage>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.StageId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<SizeEstimation>(entity =>
            {
                entity.Property(e => e.High).HasDefaultValueSql("'0'");

                entity.Property(e => e.Low).HasDefaultValueSql("'0'");

                entity.Property(e => e.Medium).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Models.Task>(entity =>
            {
                entity.Property(e => e.EstimatedHours).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsPriority).HasDefaultValueSql("'0'");

                entity.Property(e => e.Progress).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TaskDependency>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.Dependency })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<Wb>(entity =>
            {
                entity.Property(e => e.High).HasDefaultValueSql("'0'");

                entity.Property(e => e.Low).HasDefaultValueSql("'0'");

                entity.Property(e => e.Medium).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WebRoute>(entity =>
            {
                entity.Property(e => e.IsClosure).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsGroup).HasDefaultValueSql("'0'");

                entity.Property(e => e.IsResourceful).HasDefaultValueSql("'1'");

                entity.Property(e => e.Middleware).HasDefaultValueSql("''");

                entity.Property(e => e.Position).HasDefaultValueSql("'1'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
