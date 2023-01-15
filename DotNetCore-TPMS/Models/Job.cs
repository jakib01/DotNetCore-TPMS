using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("jobs")]
    [Index(nameof(Queue), Name = "jobs_queue_index")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Job
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("queue")]
        public string Queue { get; set; } = null!;
        [Column("payload")]
        public string Payload { get; set; } = null!;
        [Column("attempts", TypeName = "tinyint(3) unsigned")]
        public byte Attempts { get; set; }
        [Column("reserved_at", TypeName = "int(10) unsigned")]
        public uint? ReservedAt { get; set; }
        [Column("available_at", TypeName = "int(10) unsigned")]
        public uint AvailableAt { get; set; }
        [Column("created_at", TypeName = "int(10) unsigned")]
        public uint CreatedAt { get; set; }
    }
}
