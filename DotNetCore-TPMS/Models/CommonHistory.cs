using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("common_histories")]
    [Index(nameof(ModelType), nameof(ModelId), Name = "common_histories_model_type_model_id_index")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class CommonHistory
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("model_type")]
        public string ModelType { get; set; } = null!;
        [Column("model_id", TypeName = "bigint(20) unsigned")]
        public ulong ModelId { get; set; }
        [Column("old_record")]
        public string OldRecord { get; set; } = null!;
        [Column("new_record")]
        public string NewRecord { get; set; } = null!;
        [Column("action", TypeName = "enum('delete','update')")]
        public string Action { get; set; } = null!;
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
