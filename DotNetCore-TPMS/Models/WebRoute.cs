using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("web_routes")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WebRoute
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("url")]
        [StringLength(255)]
        public string? Url { get; set; }
        [Column("url_name")]
        [StringLength(255)]
        public string? UrlName { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("http_method")]
        [StringLength(10)]
        public string? HttpMethod { get; set; }
        [Column("is_resourceful")]
        public bool? IsResourceful { get; set; }
        [Column("is_group")]
        public bool? IsGroup { get; set; }
        [Column("is_closure")]
        public bool? IsClosure { get; set; }
        [Column("action_class", TypeName = "int(11)")]
        public int? ActionClass { get; set; }
        [Column("action_method")]
        [StringLength(255)]
        public string? ActionMethod { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("excluded_methods")]
        [StringLength(255)]
        public string? ExcludedMethods { get; set; }
        [Column("alt_routes")]
        [StringLength(255)]
        public string? AltRoutes { get; set; }
        [Column("group_params")]
        [StringLength(255)]
        public string? GroupParams { get; set; }
        [Column("where_params")]
        [StringLength(255)]
        public string? WhereParams { get; set; }
        [Column("order")]
        [StringLength(100)]
        public string? Order { get; set; }
        [Column("position", TypeName = "smallint(6)")]
        public short Position { get; set; }
        [Column("parent_id", TypeName = "int(11)")]
        public int? ParentId { get; set; }
        [Column("restored_at", TypeName = "datetime")]
        public DateTime? RestoredAt { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }
        [Column("created_by", TypeName = "bigint(20) unsigned")]
        public ulong? CreatedBy { get; set; }
        [Column("updated_by", TypeName = "bigint(20) unsigned")]
        public ulong? UpdatedBy { get; set; }
        [Column("deleted_by", TypeName = "bigint(20) unsigned")]
        public ulong? DeletedBy { get; set; }
        [Column("restored_by", TypeName = "bigint(20) unsigned")]
        public ulong? RestoredBy { get; set; }
        [Column("middleware")]
        [StringLength(255)]
        public string? Middleware { get; set; }
    }
}
