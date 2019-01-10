using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table(name: "inv_Body")]
    public class Body
    {
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "HeadId")]
        public int HeadId { get; set; }

        [Column(name: "RowNumber")]
        public int RowNumber { get; set; }

        [Column(name: "ProductId")]
        public int ProductId { get; set; }

        [Column(name: "Count")]
        public decimal Count { get; set; }
    }
}
