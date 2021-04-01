using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Laison.Lapis.Shared.Host
{
    public static class SwaggerGenServiceCollectionExtensions
    {
        public static IServiceCollection AddSwaggerGen(this IServiceCollection services, params DocApiInfo[] infos)
        {
            services.AddSwaggerGen(options =>
            {
                foreach (var info in infos)
                {
                    options.SwaggerDoc(info.Name, new OpenApiInfo { Title = info.Title, Description = info.Description });
                }

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT授权直接在下框中输入Bearer {token}（注意两者之间是一个空格）\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });

                // 此处用于接口分组过滤
                //options.DocInclusionPredicate((docName, description) => true);
                options.DocInclusionPredicate((docName, description) =>
                {
                    if (!description.TryGetMethodInfo(out MethodInfo methodInfo))
                    {
                        return false;
                    }

                    var versions = methodInfo.DeclaringType
                        .GetCustomAttributes(true)
                        .OfType<ApiExplorerSettingsAttribute>()
                        .Select(attr => attr.GroupName)
                        .ToList();

                    if (docName == "Default")
                    {
                        return true;
                    }

                    return versions.Any(v => v.ToString() == docName);
                });

                options.CustomSchemaIds(type => type.FullName);

                options.DocumentFilter<HiddenApiFilter>();

                var xmlPaths = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly);
                foreach (var path in xmlPaths)
                {
                    options.IncludeXmlComments(path);
                }

                options.EnableAnnotations();
            });

            return services;
        }
    }
}