using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("schedule_info_recurrents")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ScheduleInfoRecurrent
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [Column("calendarId")]
        [StringLength(255)]
        public string CalendarId { get; set; } = null!;
        [Column("category")]
        [StringLength(255)]
        public string Category { get; set; } = null!;
        [Column("state")]
        [StringLength(255)]
        public string State { get; set; } = null!;
        [Column("location")]
        [StringLength(255)]
        public string Location { get; set; } = null!;
        [Column("body")]
        [StringLength(255)]
        public string Body { get; set; } = null!;
        [Column("start")]
        [StringLength(255)]
        public string Start { get; set; } = null!;
        [Column("end")]
        [StringLength(255)]
        public string End { get; set; } = null!;
        [Column("agenda")]
        public string? Agenda { get; set; }
        [Column("attendee")]
        [StringLength(255)]
        public string? Attendee { get; set; }
        [Column("recurrent_type")]
        [StringLength(255)]
        public string RecurrentType { get; set; } = null!;
        [Column("year")]
        [StringLength(255)]
        public string? Year { get; set; }
        [Column("month")]
        [StringLength(255)]
        public string? Month { get; set; }
        [Column("weekNo")]
        [StringLength(255)]
        public string? WeekNo { get; set; }
        [Column("weekDay")]
        [StringLength(255)]
        public string WeekDay { get; set; } = null!;
        [Column("dates")]
        public string? Dates { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong CreatedBy { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
