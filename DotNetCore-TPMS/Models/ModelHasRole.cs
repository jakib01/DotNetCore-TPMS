using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("model_has_roles")]
    [Index(nameof(ModelId), nameof(ModelType), Name = "model_has_roles_model_id_model_type_index")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ModelHasRole
    {
        [Key]
        [Column("role_id", TypeName = "bigint(20) unsigned")]
        public ulong RoleId { get; set; }
        [Key]
        [Column("model_type")]
        [StringLength(191)]
        public string ModelType { get; set; } = null!;
        [Key]
        [Column("model_id", TypeName = "bigint(20) unsigned")]
        public ulong ModelId { get; set; }
    }
}
