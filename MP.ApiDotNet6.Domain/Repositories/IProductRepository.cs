using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Domain.Repositories {
    public interface IProductRepository {

        Task<Product> CreateAsync(Product product);
        Task<Product> GetByIdAsync(int id);
        Task<ICollection<Product>> GetProductAsync();
        Task EditAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
