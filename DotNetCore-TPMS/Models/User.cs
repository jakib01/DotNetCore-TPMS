using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("users")]
    [Index(nameof(Email), Name = "users_email_unique", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class User
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string Firstname { get; set; } = null!;
        [Column("lastname")]
        [StringLength(255)]
        public string Lastname { get; set; } = null!;
        [Column("email")]
        public string Email { get; set; } = null!;
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; } = null!;
        [Column("activated")]
        public bool Activated { get; set; }
        [Column("banned")]
        public bool Banned { get; set; }
        [Column("designation_id", TypeName = "bigint(20) unsigned")]
        public ulong? DesignationId { get; set; }
        [Column("activation_code")]
        [StringLength(255)]
        public string? ActivationCode { get; set; }
        [Column("activated_at", TypeName = "datetime")]
        public DateTime? ActivatedAt { get; set; }
        [Column("last_login", TypeName = "datetime")]
        public DateTime? LastLogin { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("remember_token")]
        [StringLength(100)]
        public string? RememberToken { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong? UpdatedBy { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("restored_at", TypeName = "datetime")]
        public DateTime? RestoredAt { get; set; }
        [Column("restored_by", TypeName = "bigint(20) unsigned")]
        public ulong? RestoredBy { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("is_external")]
        public bool? IsExternal { get; set; }
    }
}
