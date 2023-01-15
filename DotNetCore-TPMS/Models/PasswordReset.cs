using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Keyless]
    [Table("password_resets")]
    [Index(nameof(Email), Name = "password_resets_email_index")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class PasswordReset
    {
        [Column("email")]
        public string Email { get; set; } = null!;
        [Column("token")]
        [StringLength(255)]
        public string Token { get; set; } = null!;
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
    }
}
