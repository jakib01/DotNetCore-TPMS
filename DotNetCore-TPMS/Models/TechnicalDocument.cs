using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("technical_documents")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class TechnicalDocument
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong ProjectId { get; set; }
        [Column("task_id", TypeName = "bigint(20) unsigned")]
        public ulong TaskId { get; set; }
        [Column("process_flow")]
        [StringLength(255)]
        public string? ProcessFlow { get; set; }
        [Column("algorithm")]
        [StringLength(255)]
        public string? Algorithm { get; set; }
        [Column("business_logic")]
        [StringLength(255)]
        public string? BusinessLogic { get; set; }
        [Column("related_tables")]
        [StringLength(255)]
        public string? RelatedTables { get; set; }
        [Column("input_field")]
        [StringLength(255)]
        public string? InputField { get; set; }
        [Column("except_field")]
        [StringLength(255)]
        public string? ExceptField { get; set; }
        [Column("table_input_logic")]
        [StringLength(255)]
        public string? TableInputLogic { get; set; }
        [Column("dependencies_forms")]
        [StringLength(255)]
        public string? DependenciesForms { get; set; }
        [Column("dependencies_tables")]
        [StringLength(255)]
        public string? DependenciesTables { get; set; }
        [Column("form_validations")]
        [StringLength(255)]
        public string? FormValidations { get; set; }
        [Column("output")]
        [StringLength(255)]
        public string? Output { get; set; }
        [Column("controller_name")]
        [StringLength(255)]
        public string? ControllerName { get; set; }
        [Column("model_name")]
        [StringLength(255)]
        public string? ModelName { get; set; }
        [Column("view")]
        [StringLength(255)]
        public string? View { get; set; }
        [Column("involved_developers")]
        [StringLength(255)]
        public string? InvolvedDevelopers { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong? UpdatedBy { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("restored_by", TypeName = "bigint(20) unsigned")]
        public ulong? RestoredBy { get; set; }
        [Column("restored_at", TypeName = "datetime")]
        public DateTime? RestoredAt { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
