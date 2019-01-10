namespace BusinessLogic.Models
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public bool isSale { get; set; }
    }
}
