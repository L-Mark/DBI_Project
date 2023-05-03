﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace aether_db.Models
{
    [Index("Username", Name = "UQ__Users__536C85E4C51CCE03", IsUnique = true)]
    [Index("Number", Name = "UQ__Users__78A1A19D864679BE", IsUnique = true)]
    [Index("Email", Name = "UQ__Users__A9D10534DDDCB827", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            Commands = new HashSet<Command>();
            Devices = new HashSet<Device>();
        }

        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string Password { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string Number { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? last_login { get; set; }

        [InverseProperty("User")]
        public virtual UserPreference UserPreference { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Command> Commands { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Device> Devices { get; set; }
    }
}