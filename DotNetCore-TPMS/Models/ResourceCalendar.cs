using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("resource_calendars")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ResourceCalendar
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("resource_id", TypeName = "int(10) unsigned")]
        public uint ResourceId { get; set; }
        [Column("beginning_time", TypeName = "datetime")]
        public DateTime BeginningTime { get; set; }
        [Column("end_time", TypeName = "datetime")]
        public DateTime EndTime { get; set; }
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
    }
}
