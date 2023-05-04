using MP.Api.DotNet6.Application.DTOs;

namespace MP.Api.DotNet6.Application.Services.Interfaces {
    public interface IPersonService {

        Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO);
    }
}
