using FluentValidation;

using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class UserVehicleValidator : AbstractValidator<UserVehicleUpsertDto>
    {
        public UserVehicleValidator()
        {
            RuleFor(r => r.PickUp).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.Return).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.VehicleId).NotNull().WithErrorCode(ErrorCodes.NotNull);
            RuleFor(r => r.UserId).NotNull().WithErrorCode(ErrorCodes.NotNull);
        }
    }
}


