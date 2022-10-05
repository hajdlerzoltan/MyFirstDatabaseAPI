using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseAPI.Models
{
    public partial class UserDatum
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("ranombool")]
        public bool Ranombool { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserData")]
        public virtual User User { get; set; } = null!;
    }
}
