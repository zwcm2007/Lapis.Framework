﻿using Laison.Lapis.Prepayment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(PrepaymentEntityFrameworkCoreTestModule)
        )]
    public class PrepaymentDomainTestModule : AbpModule
    {
        
    }
}
