using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("meeting_decitions")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class MeetingDecition
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("decision")]
        public string? Decision { get; set; }
        [Column("responsible_user_id")]
        [StringLength(255)]
        public string? ResponsibleUserId { get; set; }
        [Column("priority")]
        [StringLength(255)]
        public string? Priority { get; set; }
        [Column("due_date")]
        [StringLength(255)]
        public string? DueDate { get; set; }
        [Column("attatchment_id")]
        [StringLength(255)]
        public string? AttatchmentId { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("schedule_id", TypeName = "bigint(20) unsigned")]
        public ulong? ScheduleId { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("project_id", TypeName = "int(11)")]
        public int? ProjectId { get; set; }
        [Column("remarks")]
        public string? Remarks { get; set; }
        [Column("task_status", TypeName = "tinyint(4)")]
        public sbyte? TaskStatus { get; set; }
    }
}
