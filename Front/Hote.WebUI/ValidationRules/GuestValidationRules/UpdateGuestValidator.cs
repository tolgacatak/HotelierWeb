using FluentValidation;
using Hote.WebUI.Dtos.GuestDto;

namespace Hote.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name space can not be empty!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname space can not be empty!");
            RuleFor(x => x.City).NotEmpty().WithMessage("City space can not be empty!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter min 3 character!");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Please enter min 2 character!");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Please enter min 3 character!");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter max 20 character!");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("Please enter mxa 30 character!");
            RuleFor(x => x.City).MaximumLength(15).WithMessage("Please enter min 15 character!");
        }
    }
}
