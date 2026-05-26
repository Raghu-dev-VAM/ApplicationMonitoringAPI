using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Context;

namespace ApplicationEndpointsApp.Data.Repositories;

public class SectionRepository : Repository<Section>, ISectionRepository
{
    private readonly AppDbContext _context;

    public SectionRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Section>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken)
    {
        return await _context.Sections
            .Include(s => s.Application)
            .Where(s => s.ApplicationId == applicationId)
            .ToListAsync(cancellationToken);
    }
}
