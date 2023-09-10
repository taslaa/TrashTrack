using Microsoft.EntityFrameworkCore.Storage;

using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public readonly ICountriesRepository CountriesRepository;
        public readonly ICitiesRepository CitiesRepository;
        public readonly IPhotosRepository PhotosRepository;
        public readonly IUsersRepository UsersRepository;
        public readonly IVehicleModelsRepository VehicleModelsRepository;
        public readonly IReportsRepository ReportsRepository;
        public readonly IReportTypesRepository ReportTypesRepository;
        public readonly IFeedbacksRepository FeedbacksRepository;
        public readonly IGarbagesRepository GarbagesRepository;
        public readonly INotificationsRepository NotificationsRepository;
        public readonly IRewardsRepository RewardsRepository;
        public readonly ISchedulesRepository SchedulesRepository;
        public readonly IUserRewardsRepository UserRewardsRepository;
        public readonly IVehiclesRepository VehiclesRepository;


        public UnitOfWork(
            DatabaseContext databaseContext,
            ICountriesRepository countriesRepository,
            ICitiesRepository citiesRepository,
            IPhotosRepository photosRepository,
            IUsersRepository usersRepository,
            IVehicleModelsRepository vehicleModelsRepository,
            IReportsRepository reportsRepository,
            IReportTypesRepository reportTypesRepository,
            IFeedbacksRepository feedbacksRepository,
            IGarbagesRepository garbagesRepository,
            INotificationsRepository notificationsRepository,
            IRewardsRepository rewardsRepository,
            ISchedulesRepository schedulesRepository,
            IUserRewardsRepository userRewardsRepository,
            IVehiclesRepository vehiclesRepository
            )
        {
            _databaseContext = databaseContext;

            CountriesRepository = countriesRepository;
            CitiesRepository = citiesRepository;
            UsersRepository = usersRepository;
            VehicleModelsRepository = vehicleModelsRepository;
            ReportsRepository = reportsRepository;
            ReportTypesRepository = reportTypesRepository;
            FeedbacksRepository = feedbacksRepository;
            GarbagesRepository = garbagesRepository;
            NotificationsRepository= notificationsRepository;
            RewardsRepository= rewardsRepository;
            SchedulesRepository= schedulesRepository;
            SchedulesRepository = schedulesRepository;
            UserRewardsRepository= userRewardsRepository;
            VehiclesRepository = vehiclesRepository;
            PhotosRepository= photosRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.SaveChangesAsync(cancellationToken);
        }
    }
}
