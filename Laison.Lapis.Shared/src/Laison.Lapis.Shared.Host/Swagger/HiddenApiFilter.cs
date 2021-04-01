using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace Laison.Lapis.Shared.Host
{
    /// <summary>
    /// 隐藏接口，不生成到swagger文档展示（Swashbuckle.AspNetCore 5.0.0）
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public partial class HiddenApiAttribute : Attribute { }

    public class HiddenApiFilter : IDocumentFilter
    {
        /// <summary>
        /// 重写Apply方法，移除隐藏接口的生成
        /// </summary>
        /// <param name="swaggerDoc">swagger文档文件</param>
        /// <param name="context"></param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (ApiDescription apiDescription in context.ApiDescriptions)
            {
                var api = apiDescription.ActionDescriptor as ControllerActionDescriptor;

                if (api.ControllerName.StartsWith("Abp"))//过滤的核心逻辑
                {
                    string key = "/" + apiDescription.RelativePath;
                    if (key.Contains("?"))
                    {
                        int idx = key.IndexOf("?", StringComparison.Ordinal);
                        key = key.Substring(0, idx);
                    }
                    swaggerDoc.Paths.Remove(key);
                }
            }
        }
    }
}