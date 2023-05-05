
using MP.Api.DotNet6.Application.DTOs;

namespace MP.Api.DotNet6.Application.Services.Interfaces {
    public interface IPurchaseService {

        Task<ResultService<PurchaseDTO>> CreateAsync(PurchaseDTO purchaseDTO);

    }
}
