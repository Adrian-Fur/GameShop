namespace GameShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task <ServiceResponse<List<Product>>> SearchProduct(string searchText);
        Task <ServiceResponse<List<string>>> SearchProductSuggestion(string searchText);
    }
}
