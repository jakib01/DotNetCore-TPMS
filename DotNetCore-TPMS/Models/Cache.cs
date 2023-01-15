using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Keyless]
    [Table("cache")]
    [Index(nameof(Key), Name = "cache_key_unique", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Cache
    {
        [Column("key")]
        public string Key { get; set; } = null!;
        [Column("value")]
        [StringLength(255)]
        public string Value { get; set; } = null!;
        [Column("expiration", TypeName = "int(11)")]
        public int Expiration { get; set; }
    }
}
