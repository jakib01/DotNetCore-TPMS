using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("project_stage")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ProjectStage
    {
        [Key]
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong ProjectId { get; set; }
        [Key]
        [Column("stage_id", TypeName = "bigint(20) unsigned")]
        public ulong StageId { get; set; }
    }
}
