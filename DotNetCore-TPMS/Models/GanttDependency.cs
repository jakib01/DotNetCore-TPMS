using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("gantt_dependencies")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class GanttDependency
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("predecessorId", TypeName = "int(11)")]
        public int PredecessorId { get; set; }
        [Column("successorId", TypeName = "int(11)")]
        public int SuccessorId { get; set; }
        [Column("type", TypeName = "int(11)")]
        public int Type { get; set; }
        [Column("projectID", TypeName = "int(11)")]
        public int ProjectId { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
