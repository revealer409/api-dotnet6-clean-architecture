using AutoMapper;
using MP.Api.DotNet6.Application.DTOs;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.Api.DotNet6.Application.Mappings {
    public class DomainToDTOMapping : Profile {

        public DomainToDTOMapping() {
            CreateMap<Person, PersonDTO>();


        }
    }
}
