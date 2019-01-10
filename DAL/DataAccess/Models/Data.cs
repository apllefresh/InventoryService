using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table(name: "inv_Date")]
    public class Data
    {
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "Date")]
        public DateTime Date { get; set; }
    }
}
