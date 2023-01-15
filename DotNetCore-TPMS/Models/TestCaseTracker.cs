using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("test_case_trackers")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class TestCaseTracker
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("serial", TypeName = "int(11)")]
        public int? Serial { get; set; }
        [Column("task_id", TypeName = "bigint(20) unsigned")]
        public ulong? TaskId { get; set; }
        [Column("movement_id", TypeName = "bigint(20) unsigned")]
        public ulong? MovementId { get; set; }
        [Column("test_case_id", TypeName = "bigint(20) unsigned")]
        public ulong? TestCaseId { get; set; }
        [Column("start_time", TypeName = "datetime")]
        public DateTime? StartTime { get; set; }
        [Column("end_time", TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        [Column("is_current")]
        public bool? IsCurrent { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong UpdatedBy { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
    }
}
