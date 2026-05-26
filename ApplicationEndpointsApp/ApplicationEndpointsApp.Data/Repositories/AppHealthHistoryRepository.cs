using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Context;

namespace ApplicationEndpointsApp.Data.Repositories;

public class AppHealthHistoryRepository : Repository<AppHealthHistory>, IAppHealthHistoryRepository
{
    private readonly AppDbContext _context;

    public AppHealthHistoryRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AppHealthHistory>> GetByUrlIdAsync(long urlId, CancellationToken cancellationToken)
    {
        return await _context.AppHealthHistories
            .Include(h => h.Url)
            .Where(h => h.UrlId == urlId)
            .ToListAsync(cancellationToken);
    }
}
