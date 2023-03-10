using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("movement_statuses")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class MovementStatus
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("movement_id", TypeName = "bigint(20) unsigned")]
        public ulong MovementId { get; set; }
        [Column("task_id", TypeName = "bigint(20) unsigned")]
        public ulong TaskId { get; set; }
        [Column("previous_status", TypeName = "int(11)")]
        public int PreviousStatus { get; set; }
        /// <summary>
        /// Task Status, Pending, Assigned, In Progress, Resolve etc.
        /// </summary>
        [Column("status", TypeName = "int(11)")]
        public int Status { get; set; }
        /// <summary>
        /// The user who has been changed the status
        /// </summary>
        [Column("changed_by", TypeName = "bigint(20) unsigned")]
        public ulong ChangedBy { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
