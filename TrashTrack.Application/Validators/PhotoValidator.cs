using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class PhotoValidator : AbstractValidator<PhotoUpsertDto>
    {
        public PhotoValidator()
        {
            RuleFor(c => c.Data).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(c => c.ContentType).NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(c => c.GarbageId).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
