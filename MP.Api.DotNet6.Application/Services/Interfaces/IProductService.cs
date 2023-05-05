using MP.Api.DotNet6.Application.DTOs;

namespace MP.Api.DotNet6.Application.Services.Interfaces {
    public interface IProductService {

        Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO); 
    
        Task<ResultService<ProductDTO>> GetByIdAsync(int id);

        Task<ResultService<ICollection<ProductDTO>>> GetAsync();
    }
}
