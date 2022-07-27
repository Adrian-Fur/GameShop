namespace GameShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task <ServiceResponse<ProductSearchResultDto>> SearchProduct(string searchText, int page);
        Task <ServiceResponse<List<string>>> SearchProductSuggestion(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
    }
}
