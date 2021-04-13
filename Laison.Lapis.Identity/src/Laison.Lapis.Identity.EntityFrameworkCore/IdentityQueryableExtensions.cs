using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    public static class IdentityQueryableExtensions
    {
        public static IQueryable<User> IncludeDetails(this IQueryable<User> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.Roles)
                .Include(x => x.Organizations);
        }

        public static IQueryable<Organization> IncludeDetails(this IQueryable<Organization> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable.Include(x => x.Roles);
        }
    }
}