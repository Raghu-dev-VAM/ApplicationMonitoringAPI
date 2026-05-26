using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Context;

namespace ApplicationEndpointsApp.Data.Repositories;

public class SlideApplicationRepository : Repository<SlideApplication>, ISlideApplicationRepository
{
    public SlideApplicationRepository(AppDbContext context) : base(context) { }
}
