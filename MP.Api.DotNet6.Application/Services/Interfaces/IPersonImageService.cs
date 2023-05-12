using MP.Api.DotNet6.Application.DTOs;

namespace MP.Api.DotNet6.Application.Services.Interfaces {
    public interface IPersonImageService {

        Task<ResultService> CreateImageBase64Async(PersonImageDTO personImageDTO);
    }
}
