using FluentValidation;

namespace MP.Api.DotNet6.Application.DTOs.Validations {
    public class ProductDTOValidator : AbstractValidator<ProductDTO> {

        public ProductDTOValidator() {

            RuleFor(x => x.CodErp)
                .NotEmpty()
                .NotNull()
                .WithMessage("CodErp deve ser informado!");

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name deve ser informado!");

            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("Price deve ser maior que zero!");
        }
    }
}
