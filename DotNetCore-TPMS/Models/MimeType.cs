using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("mime_types")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class MimeType
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("mime_type")]
        [StringLength(255)]
        public string? MimeType1 { get; set; }
        [Column("ext")]
        [StringLength(255)]
        public string? Ext { get; set; }
        [Column("label")]
        [StringLength(255)]
        public string? Label { get; set; }
        [Column("group")]
        [StringLength(30)]
        public string? Group { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
