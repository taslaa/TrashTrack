using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class UserRewardValidator : AbstractValidator<UserRewardUpsertDto>
    {
        public UserRewardValidator()
        {
            RuleFor(r => r.DateEarned).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.UserId).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.RewardId).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}


