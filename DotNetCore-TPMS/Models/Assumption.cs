using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("assumptions")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Assumption
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("platform", TypeName = "int(11)")]
        public int Platform { get; set; }
        [Column("module_id", TypeName = "bigint(20) unsigned")]
        public ulong ModuleId { get; set; }
        [Column("complexity_level", TypeName = "int(11)")]
        public int ComplexityLevel { get; set; }
        [Column("weightage")]
        public double? Weightage { get; set; }
        [Column("features", TypeName = "int(11)")]
        public int? Features { get; set; }
        [Column("input", TypeName = "int(11)")]
        public int? Input { get; set; }
        [Column("tables", TypeName = "int(11)")]
        public int? Tables { get; set; }
        [Column("lines_of_code", TypeName = "int(11)")]
        public int? LinesOfCode { get; set; }
        [Column("lines_of_code_html", TypeName = "int(11)")]
        public int? LinesOfCodeHtml { get; set; }
        [Column("lines_of_code_js", TypeName = "int(11)")]
        public int? LinesOfCodeJs { get; set; }
        [Column("lines_of_code_css", TypeName = "int(11)")]
        public int? LinesOfCodeCss { get; set; }
        [Column("lines_of_code_crystal", TypeName = "int(11)")]
        public int? LinesOfCodeCrystal { get; set; }
        [Column("no_of_components", TypeName = "int(11)")]
        public int? NoOfComponents { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int? ProjectId { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong? UpdatedBy { get; set; }
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
