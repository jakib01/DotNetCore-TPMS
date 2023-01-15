using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("size_estimations")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class SizeEstimation
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("complexity")]
        [StringLength(255)]
        public string Complexity { get; set; } = null!;
        [Column("low", TypeName = "int(11)")]
        public int? Low { get; set; }
        [Column("medium", TypeName = "int(11)")]
        public int? Medium { get; set; }
        [Column("high", TypeName = "int(11)")]
        public int? High { get; set; }
        [Column("type", TypeName = "int(11)")]
        public int? Type { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int? ProjectId { get; set; }
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
