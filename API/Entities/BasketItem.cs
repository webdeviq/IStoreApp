using System.ComponentModel.DataAnnotations.Schema;
using API.Models;

namespace API.Entities
{
    [Table("BasketItems")]
    public class BasketItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        // Navigation Property
        public int ProductId { get; set; }
        public Product Product { get; set; } = new(); // One to one.
        public int BasketId { get; set; }
        public Basket Basket { get; set; } = new();

    }
}