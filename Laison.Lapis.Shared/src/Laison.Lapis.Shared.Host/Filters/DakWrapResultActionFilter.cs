using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Laison.Lapis.Shared.Host
{
    /// <summary>
    /// 自定义动作过滤器
    /// </summary>
    public class DakWrapResultActionFilter : IAsyncResultFilter, ITransientDependency
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (!context.ActionDescriptor.IsControllerAction() || !context.ActionDescriptor.HasObjectResult())
            {
                await next();
                return;
            }

            if (context.HttpContext.Response.StatusCode == (int)HttpStatusCode.OK)
            {
                var response = new AjaxResponse(true)
                {
                    Result = (context.Result as ObjectResult)?.Value
                };

                context.Result = new ObjectResult(response);
            }

            await next();
        }
    }
}