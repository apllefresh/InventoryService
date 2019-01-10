using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table(name: "inv_Result")]
    public class Result
    {
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "DateId")]
        public int DateId { get; set; }

        [Column(name: "ProductId")]
        public int ProductId { get; set; }

        [Column(name: "CountRemain")]
        public decimal CountRemain { get; set; }

        [Column(name: "CountInvoice")]
        public decimal CountInvoice { get; set; }

        [Column(name: "CountAnnulment")]
        public decimal CountAnnulment { get; set; }

        [Column(name: "CountReturn")]
        public decimal CountReturn { get; set; }

        [Column(name: "CountSale")]
        public decimal CountSale { get; set; }

        [Column(name: "Count")]
        public decimal Count { get; set; }

        [Column(name: "Sum")]
        public decimal Sum { get; set; }
    }
}
