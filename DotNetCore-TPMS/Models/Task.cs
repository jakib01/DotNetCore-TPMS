using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("tasks")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Task
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("name", TypeName = "text")]
        public string Name { get; set; } = null!;
        [Column("description")]
        public string? Description { get; set; }
        [Column("status", TypeName = "int(11)")]
        public int Status { get; set; }
        [Column("status_date", TypeName = "datetime")]
        public DateTime StatusDate { get; set; }
        [Column("priority", TypeName = "int(11)")]
        public int Priority { get; set; }
        [Column("start_date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("progress", TypeName = "int(11)")]
        public int? Progress { get; set; }
        [Column("parent", TypeName = "int(11)")]
        public int? Parent { get; set; }
        [Column("estimated_hours", TypeName = "int(11)")]
        public int? EstimatedHours { get; set; }
        [Column("closed_on", TypeName = "datetime")]
        public DateTime? ClosedOn { get; set; }
        [Column("category_id", TypeName = "int(11)")]
        public int? CategoryId { get; set; }
        [Column("tracker_id", TypeName = "int(11)")]
        public int? TrackerId { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int? ProjectId { get; set; }
        [Column("module_id", TypeName = "bigint(20) unsigned")]
        public ulong ModuleId { get; set; }
        [Column("comment")]
        [StringLength(255)]
        public string? Comment { get; set; }
        [Column("impact_description")]
        public string? ImpactDescription { get; set; }
        [Column("issue_number")]
        [StringLength(255)]
        public string? IssueNumber { get; set; }
        [Column("page_url")]
        [StringLength(255)]
        public string? PageUrl { get; set; }
        [Column("page_id", TypeName = "int(11)")]
        public int PageId { get; set; }
        [Column("menu_name")]
        [StringLength(255)]
        public string? MenuName { get; set; }
        [Column("assigned_by", TypeName = "bigint(20) unsigned")]
        public ulong? AssignedBy { get; set; }
        [Column("assigned_to", TypeName = "bigint(20) unsigned")]
        public ulong? AssignedTo { get; set; }
        [Column("assigned_date", TypeName = "datetime")]
        public DateTime? AssignedDate { get; set; }
        [Column("requester_id", TypeName = "bigint(20) unsigned")]
        public ulong? RequesterId { get; set; }
        [Column("deployed")]
        public bool? Deployed { get; set; }
        [Column("digital_number")]
        [StringLength(255)]
        public string DigitalNumber { get; set; } = null!;
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong? UpdatedBy { get; set; }
        [Column("restored_at", TypeName = "datetime")]
        public DateTime? RestoredAt { get; set; }
        [Column("restored_by", TypeName = "bigint(20) unsigned")]
        public ulong? RestoredBy { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("is_temp")]
        public bool IsTemp { get; set; }
        [Column("is_priority")]
        public bool? IsPriority { get; set; }
        [Column("priority_sl", TypeName = "int(11)")]
        public int? PrioritySl { get; set; }
    }
}
