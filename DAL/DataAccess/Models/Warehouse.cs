using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table(name: "inv_Warehouse")]
    public class Warehouse
    {
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "Name")]
        public string Name { get; set; }

        [Column(name: "ParentId")]
        public int ParentId { get; set; }

        [Column(name: "isSale")]
        public bool isSale { get; set; }
    }
}
