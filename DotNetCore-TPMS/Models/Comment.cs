using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("comments")]
    [Index(nameof(ChildId), Name = "comments_child_id_foreign")]
    [Index(nameof(CommentableType), nameof(CommentableId), Name = "comments_commentable_type_commentable_id_index")]
    [Index(nameof(CommenterId), nameof(CommenterType), Name = "comments_commenter_id_commenter_type_index")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Comment
    {
        public Comment()
        {
            InverseChild = new HashSet<Comment>();
        }

        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("commenter_id")]
        public string? CommenterId { get; set; }
        [Column("commenter_type")]
        public string? CommenterType { get; set; }
        [Column("guest_name")]
        [StringLength(255)]
        public string? GuestName { get; set; }
        [Column("guest_email")]
        [StringLength(255)]
        public string? GuestEmail { get; set; }
        [Column("commentable_type")]
        public string CommentableType { get; set; } = null!;
        [Column("commentable_id")]
        public string CommentableId { get; set; } = null!;
        [Column("comment", TypeName = "text")]
        public string Comment1 { get; set; } = null!;
        [Required]
        [Column("approved")]
        public bool? Approved { get; set; }
        [Column("child_id", TypeName = "bigint(20) unsigned")]
        public ulong? ChildId { get; set; }
        [Column("deleted_at", TypeName = "timestamp")]
        public DateTime? DeletedAt { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(ChildId))]
        [InverseProperty(nameof(Comment.InverseChild))]
        public virtual Comment? Child { get; set; }
        [InverseProperty(nameof(Comment.Child))]
        public virtual ICollection<Comment> InverseChild { get; set; }
    }
}
