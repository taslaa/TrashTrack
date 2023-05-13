using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class LocationValidator : AbstractValidator<LocationUpsertDto>
    {
        public LocationValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(c => c.Address).NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(c => c.Latitude).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(c => c.Longitude).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
