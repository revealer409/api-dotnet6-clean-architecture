using MP.Api.DotNet6.Application.DTOs;

namespace MP.Api.DotNet6.Application.Services.Interfaces {
    public interface IUserService {

        Task<ResultService<dynamic>> GenerateTokenAsync(UserDTO userDTO);

    }
}
