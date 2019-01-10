using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table(name: "inv_Head")]
    public class Head
    {
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "CreateOn")]
        public DateTime CreateOn { get; set; }

        [Column(name: "CreateBy")]
        public int CreateBy { get; set; }

        [Column(name: "UpdateOn")]
        public DateTime UpdateOn { get; set; }

        [Column(name: "UpdateBy")]
        public int UpdateBy { get; set; }

        [Column(name: "WarehouseId")]
        public int WarehouseId { get; set; }

        [Column(name: "StatusId")]
        public int StatusId { get; set; }

        [Column(name: "DateId")]
        public int DateId { get; set; }
   
    }
}
