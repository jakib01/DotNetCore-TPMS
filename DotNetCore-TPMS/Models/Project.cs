using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("projects")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Project
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("serial", TypeName = "bigint(20)")]
        public long Serial { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; } = null!;
        [Column("description")]
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("identifier")]
        [StringLength(255)]
        public string Identifier { get; set; } = null!;
        [Column("homepage")]
        [StringLength(255)]
        public string? Homepage { get; set; }
        [Required]
        [Column("is_public")]
        public bool? IsPublic { get; set; }
        [Column("parent_id", TypeName = "int(11)")]
        public int? ParentId { get; set; }
        [Column("status", TypeName = "int(11)")]
        public int Status { get; set; }
        [Column("digital_number")]
        [StringLength(255)]
        public string DigitalNumber { get; set; } = null!;
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
        [Column("objective")]
        [StringLength(255)]
        public string? Objective { get; set; }
        [Column("funded_by", TypeName = "int(11)")]
        public int? FundedBy { get; set; }
        [Column("client_name")]
        [StringLength(255)]
        public string? ClientName { get; set; }
        [Column("competitors")]
        [StringLength(255)]
        public string? Competitors { get; set; }
        [Column("tor_info")]
        [StringLength(255)]
        public string? TorInfo { get; set; }
        [Column("technical_info")]
        [StringLength(255)]
        public string? TechnicalInfo { get; set; }
        [Column("revised")]
        public bool Revised { get; set; }
        [Column("time_revised", TypeName = "int(11)")]
        public int? TimeRevised { get; set; }
        [Column("cost_revised")]
        public double? CostRevised { get; set; }
        [Column("awarded_date")]
        public DateOnly? AwardedDate { get; set; }
        [Column("start_date")]
        public DateOnly? StartDate { get; set; }
        [Column("end_date")]
        public DateOnly? EndDate { get; set; }
        [Column("bg_status", TypeName = "int(11)")]
        public int? BgStatus { get; set; }
        [Column("bg_expired", TypeName = "datetime")]
        public DateTime? BgExpired { get; set; }
        [Column("bg_amout")]
        public double? BgAmout { get; set; }
        [Column("cost")]
        public double? Cost { get; set; }
        [Column("short_name")]
        [StringLength(255)]
        public string? ShortName { get; set; }
        [Column("project_type")]
        [StringLength(255)]
        public string ProjectType { get; set; } = null!;
        [Column("solution_component")]
        [StringLength(255)]
        public string? SolutionComponent { get; set; }
        [Column("is_assignable", TypeName = "tinyint(1) unsigned zerofill")]
        public byte? IsAssignable { get; set; }
    }
}
