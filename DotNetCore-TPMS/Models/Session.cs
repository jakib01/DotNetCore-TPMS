using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Keyless]
    [Table("sessions")]
    [Index(nameof(Id), Name = "sessions_id_unique", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Session
    {
        [Column("id")]
        public string Id { get; set; } = null!;
        [Column("user_id", TypeName = "int(11)")]
        public int? UserId { get; set; }
        [Column("ip_address")]
        [StringLength(45)]
        public string? IpAddress { get; set; }
        [Column("user_agent")]
        [StringLength(255)]
        public string? UserAgent { get; set; }
        [Column("payload")]
        [StringLength(255)]
        public string Payload { get; set; } = null!;
        [Column("last_activity", TypeName = "int(11)")]
        public int LastActivity { get; set; }
    }
}
