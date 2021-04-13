using System.Linq;
using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
                //.Include(x => x.OrganizationUnits)
                ;
        }

        //public static IQueryable<IdentityRole> IncludeDetails(this IQueryable<IdentityRole> queryable, bool include = true)
        //{
        //    if (!include)
        //    {
        //        return queryable;
        //    }

        //    return queryable
        //        .Include(x => x.Claims);
        //}

        public static IQueryable<Organization> IncludeDetails(this IQueryable<Organization> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
               // .Include(x => x.Roles)
                ;
        }
    }
}