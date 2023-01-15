using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("resource_values")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ResourceValue
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong UserId { get; set; }
        [Column("resource_role_id", TypeName = "int(10) unsigned")]
        public uint ResourceRoleId { get; set; }
        [Column("skill")]
        [StringLength(255)]
        public string? Skill { get; set; }
        [Column("expertise")]
        [StringLength(255)]
        public string Expertise { get; set; } = null!;
        [Column("currency_of_value")]
        [StringLength(255)]
        public string CurrencyOfValue { get; set; } = null!;
        [Column("value")]
        public double Value { get; set; }
        [Column("currency_of_rate")]
        [StringLength(255)]
        public string? CurrencyOfRate { get; set; }
        [Column("rate")]
        public double? Rate { get; set; }
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
        [Column("outside_resource_text")]
        [StringLength(255)]
        public string? OutsideResourceText { get; set; }
    }
}
