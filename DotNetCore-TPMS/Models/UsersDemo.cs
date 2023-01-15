using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("users_demo")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class UsersDemo
    {
        [Key]
        [Column("id", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string Firstname { get; set; } = null!;
        [Column("lastname")]
        [StringLength(255)]
        public string Lastname { get; set; } = null!;
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; } = null!;
    }
}
