using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("navigations")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Navigation
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("serial", TypeName = "int(11)")]
        public int Serial { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [Column("subtitle")]
        [StringLength(255)]
        public string? Subtitle { get; set; }
        [Column("parent_id", TypeName = "bigint(20)")]
        public long? ParentId { get; set; }
        [Column("description", TypeName = "text")]
        public string? Description { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
