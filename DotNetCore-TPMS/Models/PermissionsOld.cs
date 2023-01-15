using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("permissions_old")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class PermissionsOld
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; } = null!;
        [Column("model_type", TypeName = "bigint(20)")]
        public long? ModelType { get; set; }
        [Column("model_id", TypeName = "bigint(20) unsigned")]
        public ulong? ModelId { get; set; }
        [Column("parameter")]
        [StringLength(200)]
        public string? Parameter { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
