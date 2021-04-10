using Volo.Abp.Application.Services;

namespace Laison.Lapis.Prepayment.Application
{
    public abstract class PrepaymentAppServiceBase : ApplicationService
    {
        protected PrepaymentAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisPrepaymentApplicationModule);
        }
    }
}
