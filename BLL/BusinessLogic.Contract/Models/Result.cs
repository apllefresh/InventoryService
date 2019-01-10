namespace BusinessLogic.Contract.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int DateId { get; set; }

        public int ProductId { get; set; }

        public decimal CountRemain { get; set; }

        public decimal CountInvoice { get; set; }

        public decimal CountAnnulment { get; set; }

        public decimal CountReturn { get; set; }

        public decimal CountSale { get; set; }

        public decimal Count { get; set; }

        public decimal Sum { get; set; }
    }
}
