using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Context;

namespace ApplicationEndpointsApp.Data.Repositories;

public class UrlRepository : Repository<Url>, IUrlRepository
{
    private readonly AppDbContext _context;

    public UrlRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Url>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken)
    {
        return await _context.Urls
            .Include(u => u.Application)
            .Include(u => u.Environment)
            .Include(u => u.Section)
            .Where(u => u.ApplicationId == applicationId)
            .ToListAsync(cancellationToken);
    }
}
