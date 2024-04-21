using API.Models;

namespace API.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; set; } = string.Empty;
        public List<BasketItem> Items { get; set; } = new(); // One to many.

        public void AddItem(Product product, int quantity)
        {
            if (Items.All(item => item.ProductId != product.Id))
            {
                Items.Add(new BasketItem { Product = product, Quantity = quantity });
            }
            BasketItem? existingItem = Items.FirstOrDefault(item => item.ProductId == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
        }
        public void RemoveItem(int productId, int quantity)
        {
            BasketItem? targetItem = Items.FirstOrDefault(item => item.ProductId == productId);
            if (targetItem == null) return;
            targetItem.Quantity -= quantity;
            if (targetItem.Quantity == 0) Items.Remove(targetItem);
        }

    }
}