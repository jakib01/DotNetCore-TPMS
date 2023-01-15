using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("movements")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Movement
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("serial", TypeName = "bigint(20)")]
        public long Serial { get; set; }
        [Column("task_id", TypeName = "bigint(20) unsigned")]
        public ulong? TaskId { get; set; }
        [Column("module_id", TypeName = "bigint(20) unsigned")]
        public ulong? ModuleId { get; set; }
        [Column("page_id", TypeName = "bigint(20) unsigned")]
        public ulong? PageId { get; set; }
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong? ProjectId { get; set; }
        [Column("tracker_id", TypeName = "smallint(5) unsigned")]
        public ushort? TrackerId { get; set; }
        [Column("from_stage", TypeName = "bigint(20) unsigned")]
        public ulong? FromStage { get; set; }
        [Column("to_stage", TypeName = "bigint(20) unsigned")]
        public ulong? ToStage { get; set; }
        [Required]
        [Column("is_current")]
        public bool? IsCurrent { get; set; }
        [Column("moved_by", TypeName = "bigint(20) unsigned")]
        public ulong? MovedBy { get; set; }
        [Column("priority", TypeName = "smallint(5) unsigned")]
        public ushort? Priority { get; set; }
        [Column("estimated_hours", TypeName = "double(10,4)")]
        public double? EstimatedHours { get; set; }
        [Column("assigned_to", TypeName = "bigint(20) unsigned")]
        public ulong? AssignedTo { get; set; }
        [Column("progress", TypeName = "smallint(5) unsigned")]
        public ushort Progress { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
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
        [Column("start_date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("test_case_id")]
        [StringLength(255)]
        public string? TestCaseId { get; set; }
    }
}
