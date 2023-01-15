using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("phasewise_distributions")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class PhasewiseDistribution
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong ProjectId { get; set; }
        [Column("requirement_pd")]
        public double RequirementPd { get; set; }
        [Column("requirement_st")]
        public double? RequirementSt { get; set; }
        [Column("planning_pd")]
        public double PlanningPd { get; set; }
        [Column("planning_st")]
        public double? PlanningSt { get; set; }
        [Column("designing_pd")]
        public double DesigningPd { get; set; }
        [Column("designing_st")]
        public double? DesigningSt { get; set; }
        [Column("coding_pd")]
        public double CodingPd { get; set; }
        [Column("coding_st")]
        public double? CodingSt { get; set; }
        [Column("testing_pd")]
        public double TestingPd { get; set; }
        [Column("testing_st")]
        public double? TestingSt { get; set; }
        [Column("relese_implementation_pd")]
        public double ReleseImplementationPd { get; set; }
        [Column("relese_implementation_st")]
        public double? ReleseImplementationSt { get; set; }
        [Column("project_management_pd")]
        public double ProjectManagementPd { get; set; }
        [Column("project_management_st")]
        public double? ProjectManagementSt { get; set; }
        [Column("qa_pd")]
        public double QaPd { get; set; }
        [Column("qa_st")]
        public double? QaSt { get; set; }
        [Column("support_pd")]
        public double SupportPd { get; set; }
        [Column("support_st")]
        public double? SupportSt { get; set; }
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
