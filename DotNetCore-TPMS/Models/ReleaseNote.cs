using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("release_notes")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ReleaseNote
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int? ProjectId { get; set; }
        [Column("task_id")]
        [StringLength(255)]
        public string? TaskId { get; set; }
        [Column("movement_id")]
        [StringLength(255)]
        public string? MovementId { get; set; }
        [Column("status_id", TypeName = "int(11)")]
        public int? StatusId { get; set; }
        [Column("is_current", TypeName = "bigint(20) unsigned")]
        public ulong? IsCurrent { get; set; }
        [Column("release_note_no")]
        [StringLength(255)]
        public string? ReleaseNoteNo { get; set; }
        [Column("release_destination", TypeName = "bigint(20) unsigned")]
        public ulong? ReleaseDestination { get; set; }
        [Column("release_type", TypeName = "bigint(20) unsigned")]
        public ulong? ReleaseType { get; set; }
        [Column("version")]
        [StringLength(255)]
        public string? Version { get; set; }
        [Column("released_by", TypeName = "bigint(20) unsigned")]
        public ulong? ReleasedBy { get; set; }
        [Column("released_at", TypeName = "timestamp")]
        public DateTime? ReleasedAt { get; set; }
        [Column("is_deleted", TypeName = "bigint(20) unsigned")]
        public ulong? IsDeleted { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
