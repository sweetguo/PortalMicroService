using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Institute.Portal.Authorization.Roles;
using Institute.Portal.Authorization.Users;
using Institute.Portal.MultiTenancy;

namespace Institute.Portal.EntityFrameworkCore
{
    public class PortalDbContext : AbpZeroDbContext<Tenant, Role, User, PortalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
            : base(options)
        {
        }
    }
}
