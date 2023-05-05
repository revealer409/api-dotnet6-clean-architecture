using FluentValidation;

namespace MP.Api.DotNet6.Application.DTOs.Validations {
    public class PurchaseDTOValidator : AbstractValidator<PurchaseDTO> {

        public PurchaseDTOValidator() {
            RuleFor(x => x.CodErp)
                .NotEmpty()
                .NotNull()
                .WithMessage("CodErp deve ser informado");

            RuleFor(x => x.Document)
               .NotEmpty()
               .NotNull()
               .WithMessage("Document deve ser informado");
        }
    }
}
