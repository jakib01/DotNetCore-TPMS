using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("release_notes_old")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ReleaseNotesOld
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int? ProjectId { get; set; }
        [Column("module_id", TypeName = "int(10) unsigned")]
        public uint ModuleId { get; set; }
        [Column("page_id", TypeName = "int(11)")]
        public int? PageId { get; set; }
        [Column("issue_number")]
        [StringLength(255)]
        public string? IssueNumber { get; set; }
        [Column("task_name")]
        [StringLength(255)]
        public string? TaskName { get; set; }
        [Column("task_id")]
        [StringLength(255)]
        public string? TaskId { get; set; }
        [Column("task_tracker_id", TypeName = "int(11)")]
        public int? TaskTrackerId { get; set; }
        [Column("status_id", TypeName = "int(11)")]
        public int? StatusId { get; set; }
        [Column("status_date", TypeName = "datetime")]
        public DateTime? StatusDate { get; set; }
        [Column("resource_id", TypeName = "int(10) unsigned")]
        public uint? ResourceId { get; set; }
        [Column("release_note_no")]
        [StringLength(255)]
        public string? ReleaseNoteNo { get; set; }
        [Column("start_date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
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
    }
}
