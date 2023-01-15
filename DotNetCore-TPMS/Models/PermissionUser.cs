using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Table("permission_user")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class PermissionUser
    {
        [Key]
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong UserId { get; set; }
        [Key]
        [Column("permission_id", TypeName = "bigint(20) unsigned")]
        public ulong PermissionId { get; set; }
    }
}
