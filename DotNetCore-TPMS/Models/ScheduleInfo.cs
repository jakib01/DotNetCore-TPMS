using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("schedule_infos")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class ScheduleInfo
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
        [Column("comingDuration", TypeName = "int(11)")]
        public int? ComingDuration { get; set; }
        [Column("goingDuration", TypeName = "int(11)")]
        public int? GoingDuration { get; set; }
        [Column("dueDateClass")]
        [StringLength(255)]
        public string? DueDateClass { get; set; }
        [Column("customStyle")]
        [StringLength(255)]
        public string? CustomStyle { get; set; }
        [Column("isAllday")]
        public bool? IsAllday { get; set; }
        [Column("isFocused")]
        public bool? IsFocused { get; set; }
        [Column("isPending")]
        public bool? IsPending { get; set; }
        [Column("isPrivate")]
        public bool? IsPrivate { get; set; }
        [Column("isReadOnly")]
        public bool? IsReadOnly { get; set; }
        [Column("isVisible")]
        public bool? IsVisible { get; set; }
        [Column("recurrenceRule")]
        [StringLength(255)]
        public string? RecurrenceRule { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong CreatedBy { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("schedule_info_recurrents_id", TypeName = "int(10)")]
        public int? ScheduleInfoRecurrentsId { get; set; }
        [Column("meeting_schedule_client", TypeName = "int(10)")]
        public int? MeetingScheduleClient { get; set; }
        [Column("projectID", TypeName = "int(10)")]
        public int? ProjectId { get; set; }
    }
}
