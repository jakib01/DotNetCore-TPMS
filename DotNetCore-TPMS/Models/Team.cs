using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("teams")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Team
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong ProjectId { get; set; }
        [Column("stage_id", TypeName = "int(10) unsigned")]
        public uint StageId { get; set; }
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong UserId { get; set; }
        [Column("resource_value_id", TypeName = "int(10) unsigned")]
        public uint ResourceValueId { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_by", TypeName = "int(10) unsigned")]
        public uint? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "int(10) unsigned")]
        public uint? UpdatedBy { get; set; }
        [Column("deleted_by", TypeName = "int(10) unsigned")]
        public uint? DeletedBy { get; set; }
        [Column("restored_at", TypeName = "datetime")]
        public DateTime? RestoredAt { get; set; }
        [Column("restored_by", TypeName = "int(10) unsigned")]
        public uint? RestoredBy { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
