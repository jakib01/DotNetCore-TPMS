using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("module_project")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ModuleProject
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("module_id", TypeName = "int(11)")]
        public int ModuleId { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int ProjectId { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
