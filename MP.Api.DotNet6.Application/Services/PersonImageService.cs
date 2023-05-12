using MP.Api.DotNet6.Application.DTOs;
using MP.Api.DotNet6.Application.DTOs.Validations;
using MP.Api.DotNet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.Entities;
using MP.ApiDotNet6.Domain.Integrations;
using MP.ApiDotNet6.Domain.Repositories;

namespace MP.Api.DotNet6.Application.Services {
    public class PersonImageService : IPersonImageService {

        private readonly IPersonImageRepository _personImageRepository;
        private readonly IPersonRepository _personRepository;
        private readonly ISavePersonImage _savePersonImage;

        public PersonImageService(IPersonImageRepository personImageRepository, IPersonRepository personRepository, ISavePersonImage savePersonImage) {
            _personImageRepository = personImageRepository;
            _personRepository = personRepository;
            _savePersonImage = savePersonImage;
        }

        public async Task<ResultService> CreateImageBase64Async(PersonImageDTO personImageDTO) {
            if (personImageDTO == null)
                return ResultService.Fail("Objeto deve ser informado");

            var validations = new PersonImageDTOValidator().Validate(personImageDTO);

            if (!validations.IsValid)
                return ResultService.RequestError("Problemas de validação", validations);

            var person = await _personRepository.GetByIdAsync(personImageDTO.PersonId);

            if (person == null)
                return ResultService.Fail("Id pessoa não encontrado");

            var personImage = new PersonImage(person.Id, null, personImageDTO.Image);

            await _personImageRepository.CreateAsync(personImage);

            return ResultService.Ok("Imagem em base64 salva");
        }

        public async Task<ResultService> CreateImageAsync(PersonImageDTO personImageDTO) {

            if (personImageDTO == null)
                return ResultService.Fail("Objeto deve ser informado");

            var validations = new PersonImageDTOValidator().Validate(personImageDTO);

            if (!validations.IsValid)
                return ResultService.RequestError("Problemas com a validação", validations);

            var person = await _personImageRepository.GetByIdAsync(personImageDTO.PersonId);

            if (person == null)
                return ResultService.Fail("Pessoa não encontrada");

            var pathImage = _savePersonImage.Save(personImageDTO.Image);
            var personImage = new PersonImage(person.Id, pathImage, null);
            await _personImageRepository.CreateAsync(personImage);

            return ResultService.Ok("Imagem salva");
        }
    }
}
