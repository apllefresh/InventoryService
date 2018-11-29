﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table(name: "inventorydate")]
    public class InventoryDate
    {
        [Column(name:"id")]
        public int Id { get; set; }

        [Column(name: "date")]
        public DateTime Date { get; set; }
    }
}
