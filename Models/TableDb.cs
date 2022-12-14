// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    [Table("TableDB")]
    [Index("TableId", Name = "IX_Tabla", IsUnique = true)]
    public partial class TableDb
    {
        [Key]
        [Column("TableID")]
        public int TableId { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string TableName { get; set; }
    }
}