using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class ScheduleValidator : AbstractValidator<ScheduleUpsertDto>
    {
        public ScheduleValidator()
        {
            RuleFor(r => r.PickupDate).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.GarbageId).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.UserVehicleId).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}
