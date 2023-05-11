using FluentValidation;

namespace MP.Api.DotNet6.Application.DTOs.Validations {
    public class UserDTOValidator : AbstractValidator<UserDTO> {

        public UserDTOValidator() {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email deve ser informado");

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Password deve ser informada");
        }
    }
}
