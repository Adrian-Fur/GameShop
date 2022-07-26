using GameShop.Shared.Models;

namespace GameShop.Shared.Dtos
{
    public class ProductSearchResultDto
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
