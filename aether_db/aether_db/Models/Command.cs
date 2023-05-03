﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace aether_db.Models
{
    public partial class Command
    {
        [Key]
        public int CommandID { get; set; }
        public int UserID { get; set; }
        public int DeviceID { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string CommandText { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string CommandResponse { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }

        [ForeignKey("DeviceID")]
        [InverseProperty("Commands")]
        public virtual Device Device { get; set; }
        [ForeignKey("UserID")]
        [InverseProperty("Commands")]
        public virtual User User { get; set; }
    }
}