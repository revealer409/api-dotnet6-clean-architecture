using MP.Api.DotNet6.Application.DTOs;
using MP.Api.DotNet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.Repositories;
using AutoMapper;
using MP.Api.DotNet6.Application.DTOs.Validations;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.Api.DotNet6.Application.Services {
    public class PersonService : IPersonService {

        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper) {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO) {
            if (personDTO == null) 
                return ResultService.Fail<PersonDTO>("Objeto deve ser informado");

            var result = new PersonDTOValidator().Validate(personDTO);

            if (!result.IsValid)
                return ResultService.RequestError<PersonDTO>("Problema de validade!", result);

            var person = _mapper.Map<Person>(personDTO);
            var data = await _personRepository.CreateAsync(person);
            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));
        }

        public async Task<ResultService<PersonDTO>> GetByIdAsync(int id) {
            var person = await _personRepository.GetByIdAsync(id);
            
            if(person == null) {
                return ResultService.Fail<PersonDTO>("Pessoa não encontrada");
            }

            return ResultService.Ok(_mapper.Map<PersonDTO>(person));
        }

        public async Task<ResultService<ICollection<PersonDTO>>> GetAsync() {
            var people = await _personRepository.GetPeopleAsync();
            return ResultService.Ok<ICollection<PersonDTO>>(_mapper.Map<ICollection<PersonDTO>>(people));
        }

        
    }
}
