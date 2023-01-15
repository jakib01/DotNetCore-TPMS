using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("office_weeks")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class OfficeWeek
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("year", TypeName = "smallint(6)")]
        public short Year { get; set; }
        [Column("week_start_day")]
        [StringLength(255)]
        public string? WeekStartDay { get; set; }
        [Column("day1")]
        [StringLength(255)]
        public string? Day1 { get; set; }
        [Column("day2")]
        [StringLength(255)]
        public string? Day2 { get; set; }
        [Column("day1_type")]
        [StringLength(255)]
        public string? Day1Type { get; set; }
        [Column("day2_type")]
        [StringLength(255)]
        public string? Day2Type { get; set; }
        [Column("office_start_time")]
        [StringLength(255)]
        public string? OfficeStartTime { get; set; }
        [Column("office_end_time")]
        [StringLength(255)]
        public string? OfficeEndTime { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
