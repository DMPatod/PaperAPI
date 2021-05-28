using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMOG.Paper.Infrastructures.DatabaseContext
{
    public static class PaperManagementDbContextExtensions
    {
        public static IServiceCollection AddPaperDbContext(this IServiceCollection services, string connectionString)
        {
            return services;
        }
    }
}
