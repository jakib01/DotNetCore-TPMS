using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("documents")]
    [Index(nameof(DocumentableType), nameof(DocumentableId), Name = "documents_documentable_type_documentable_id_index")]
    [Index(nameof(StoredName), Name = "documents_stored_name_unique", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Document
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("stored_name")]
        public string StoredName { get; set; } = null!;
        [Column("actual_name")]
        [StringLength(255)]
        public string ActualName { get; set; } = null!;
        [Column("given_name")]
        [StringLength(255)]
        public string GivenName { get; set; } = null!;
        [Column("path")]
        [StringLength(255)]
        public string Path { get; set; } = null!;
        [Column("ext")]
        [StringLength(10)]
        public string Ext { get; set; } = null!;
        [Column("resolution")]
        [StringLength(20)]
        public string? Resolution { get; set; }
        [Column("size")]
        public double Size { get; set; }
        [Column("documentable_type")]
        public string DocumentableType { get; set; } = null!;
        [Column("documentable_id", TypeName = "bigint(20)")]
        public long DocumentableId { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
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
    }
}
