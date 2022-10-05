using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseAPI.Models
{
    public partial class User
    {
        public User()
        {
            UserData = new HashSet<UserDatum>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("username")]
        [StringLength(50)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [InverseProperty("User")]
        public virtual ICollection<UserDatum> UserData { get; set; }
    }
}
