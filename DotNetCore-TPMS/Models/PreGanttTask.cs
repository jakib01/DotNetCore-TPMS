using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("pre_gantt_tasks")]
    [Index(nameof(Key), Name = "pre_gantt_tasks_key_unique", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class PreGanttTask
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("key")]
        public string Key { get; set; } = null!;
        [Column("dependency_id", TypeName = "bigint(20) unsigned")]
        public ulong? DependencyId { get; set; }
        [Column("resource_id", TypeName = "bigint(20) unsigned")]
        public ulong? ResourceId { get; set; }
        [Column("task_type")]
        [StringLength(255)]
        public string? TaskType { get; set; }
        [Column("parent_id")]
        [StringLength(255)]
        public string? ParentId { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string? Title { get; set; }
        [Column("start")]
        [StringLength(255)]
        public string? Start { get; set; }
        [Column("end")]
        [StringLength(255)]
        public string? End { get; set; }
        [Column("progress")]
        [StringLength(255)]
        public string? Progress { get; set; }
        [Column("project_id", TypeName = "bigint(20) unsigned")]
        public ulong? ProjectId { get; set; }
        [Column("module_id", TypeName = "bigint(20) unsigned")]
        public ulong? ModuleId { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
    }
}
