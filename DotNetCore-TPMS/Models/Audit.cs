using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("audits")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Audit
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("user_type")]
        [StringLength(255)]
        public string? UserType { get; set; }
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong? UserId { get; set; }
        [Column("event")]
        [StringLength(255)]
        public string Event { get; set; } = null!;
        [Column("auditable_type")]
        [StringLength(255)]
        public string AuditableType { get; set; } = null!;
        [Column("auditable_id", TypeName = "bigint(20) unsigned")]
        public ulong AuditableId { get; set; }
        [Column("old_values")]
        public string? OldValues { get; set; }
        [Column("new_values")]
        public string? NewValues { get; set; }
        [Column("url", TypeName = "text")]
        public string? Url { get; set; }
        [Column("ip_address")]
        [StringLength(45)]
        public string? IpAddress { get; set; }
        [Column("user_agent")]
        [StringLength(255)]
        public string? UserAgent { get; set; }
        [Column("tags")]
        [StringLength(255)]
        public string? Tags { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
