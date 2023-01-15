using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("additional_tasks")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class AdditionalTask
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("category")]
        [StringLength(255)]
        public string Category { get; set; } = null!;
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong? ProjectId { get; set; }
        [Column("company_id", TypeName = "int(11)")]
        public int? CompanyId { get; set; }
        [Column("branch_id", TypeName = "int(11)")]
        public int? BranchId { get; set; }
        [Column("task_id", TypeName = "bigint(20) unsigned")]
        public ulong? TaskId { get; set; }
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong UserId { get; set; }
        [Column("date")]
        public DateOnly Date { get; set; }
        [Column("from", TypeName = "time")]
        public TimeOnly? From { get; set; }
        [Column("to", TypeName = "time")]
        public TimeOnly? To { get; set; }
        [Column("hours", TypeName = "time")]
        public TimeOnly Hours { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong? UpdatedBy { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("restored_by", TypeName = "bigint(20) unsigned")]
        public ulong? RestoredBy { get; set; }
        [Column("restored_at", TypeName = "datetime")]
        public DateTime? RestoredAt { get; set; }
        [Column("meeting_title")]
        [StringLength(100)]
        public string? MeetingTitle { get; set; }
        [Column("stakeholder_engagement")]
        [StringLength(255)]
        public string? StakeholderEngagement { get; set; }
    }
}
