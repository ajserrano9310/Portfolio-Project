using Microsoft.EntityFrameworkCore;
using personal_portfolio.Data;

namespace personal_portfolio.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectDbContext(
           serviceProvider.GetRequiredService<
               DbContextOptions<ProjectDbContext>>()))
            {
                if (context.Project.Any())
                {
                    return;
                }


            }
        }
    }
}
