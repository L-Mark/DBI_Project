﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace aether_db.Models
{
    public partial class DeviceType
    {
        public DeviceType()
        {
            Devices = new HashSet<Device>();
        }

        [Key]
        public int DeviceTypeID { get; set; }
        [Column("DeviceType")]
        [StringLength(255)]
        [Unicode(false)]
        public string DeviceType1 { get; set; }

        [InverseProperty("DeviceTypeNavigation")]
        public virtual ICollection<Device> Devices { get; set; }
    }
}