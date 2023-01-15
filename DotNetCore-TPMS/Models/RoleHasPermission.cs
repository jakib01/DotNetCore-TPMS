using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_TPMS.Models
{
    [Keyless]
    [Table("role_has_permissions")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class RoleHasPermission
    {
        [Column("permission_id", TypeName = "bigint(20) unsigned")]
        public ulong PermissionId { get; set; }
        [Column("role_id", TypeName = "bigint(20) unsigned")]
        public ulong RoleId { get; set; }
    }
}
