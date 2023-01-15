using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("test_cases")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class TestCase
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong ProjectId { get; set; }
        [Column("task_id", TypeName = "bigint(20) unsigned")]
        public ulong TaskId { get; set; }
        [Column("work_product_id", TypeName = "int(11)")]
        public int? WorkProductId { get; set; }
        [Column("integration_type", TypeName = "int(11)")]
        public int? IntegrationType { get; set; }
        [Column("test_cases_description")]
        [StringLength(255)]
        public string? TestCasesDescription { get; set; }
        [Column("test_data")]
        [StringLength(255)]
        public string? TestData { get; set; }
        [Column("conditions")]
        [StringLength(255)]
        public string? Conditions { get; set; }
        [Column("expected_result")]
        [StringLength(255)]
        public string? ExpectedResult { get; set; }
        [Column("actual_result")]
        [StringLength(255)]
        public string? ActualResult { get; set; }
        [Column("test_status")]
        [StringLength(255)]
        public string? TestStatus { get; set; }
        [Column("iteration", TypeName = "text")]
        public string? Iteration { get; set; }
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
        [Column("test_case_category")]
        [StringLength(100)]
        public string? TestCaseCategory { get; set; }
        [Column("pre_requisite")]
        [StringLength(255)]
        public string? PreRequisite { get; set; }
        [Column("select_users")]
        [StringLength(100)]
        public string? SelectUsers { get; set; }
        [Column("test_type")]
        [StringLength(10)]
        public string? TestType { get; set; }
        [Column("remarks")]
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column("movement_id", TypeName = "bigint(20) unsigned")]
        public ulong? MovementId { get; set; }
    }
}
