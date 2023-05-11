﻿using Microsoft.EntityFrameworkCore;

using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;
namespace TrashTrack.Infrastructure
{
    public class ReportTypesRepository : BaseRepository<ReportType, int, ReportTypeSearchObject>, IReportTypesRepository
    {
        public ReportTypesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
        public override Task<PagedList<ReportType>> GetPagedAsync(ReportTypeSearchObject searchObject, CancellationToken cancellationToken = default)
        {
            return DbSet
                .Where(vb => searchObject.Name == null || vb.Name.ToLower().Contains(searchObject.Name.ToLower()))
                .ToPagedListAsync(searchObject, cancellationToken);
        }
        public Task<bool> DoesExistAsync(string name, CancellationToken cancellationToken = default)
        {
            return DbSet.AnyAsync(vb => vb.Name == name, cancellationToken);
        }
    }
}