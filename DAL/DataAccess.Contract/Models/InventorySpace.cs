using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Contract.Models
{
    [Table(name: "inventoryspace")]
    public class InventorySpace
    {
        [Column(name: "id")]
        public int Id { get; set; }
        [Column(name: "name")]
        public string Name { get; set; }
    }
}
