using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class RewardValidator : AbstractValidator<RewardUpsertDto>
    {
        public RewardValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(r => r.Description).NotEmpty().WithErrorCode(ErrorCodes.NotEmpty);
            RuleFor(r => r.PointValue).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
