using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("office_holidays")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class OfficeHoliday
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("date_from")]
        public DateOnly DateFrom { get; set; }
        [Column("date_to")]
        public DateOnly? DateTo { get; set; }
        [Column("reason")]
        [StringLength(255)]
        public string? Reason { get; set; }
        [Column("type")]
        [StringLength(255)]
        public string? Type { get; set; }
        [Column("days", TypeName = "smallint(6)")]
        public short? Days { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
