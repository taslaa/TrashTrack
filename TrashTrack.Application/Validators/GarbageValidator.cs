using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class GarbageValidator : AbstractValidator<GarbageUpsertDto>
    {
        public GarbageValidator()
        {
            RuleFor(c => c.Description).NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(c => c.LocationId).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
