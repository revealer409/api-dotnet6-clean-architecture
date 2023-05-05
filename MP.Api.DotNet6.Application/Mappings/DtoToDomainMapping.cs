using AutoMapper;
using MP.Api.DotNet6.Application.DTOs;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.Api.DotNet6.Application.Mappings {
    public class DtoToDomainMapping : Profile {

        public DtoToDomainMapping() {
            CreateMap<PersonDTO, Person>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
