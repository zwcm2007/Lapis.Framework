using IdentityModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc.Response;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Json;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Security.Claims;

namespace Laison.Lapis.Shared.Host
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcModule),
        typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreSerilogModule)
        )]
    public class LapisSharedHostModule : AbpModule
    {
        private const string DefaultCorsPolicyName = "Default";

        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            // compatible with identity server claims.
            AbpClaimTypes.UserId = JwtClaimTypes.Id;
            AbpClaimTypes.UserName = "username";
            AbpClaimTypes.Name = JwtClaimTypes.Name;
            AbpClaimTypes.PhoneNumber = JwtClaimTypes.PhoneNumber;
            AbpClaimTypes.Email = JwtClaimTypes.Email;
            AbpClaimTypes.Role = JwtClaimTypes.Role;
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();

            //Configure<AbpMultiTenancyOptions>(options =>
            //{
            //    options.IsEnabled = MultiTenancyConsts.IsEnabled;
            //});

            // Localization
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
            });

            // Authentication
            var key = configuration["Jwt:IssuerSigningKey"]?.ToString();
            var audience = configuration["Jwt:ValidAudience"]?.ToString();
            var issuer = configuration["Jwt:ValidIssuer"]?.ToString();
            context.Services.AddJwtAuthentication(key, issuer, audience);

            // Cache
            Configure<AbpDistributedCacheOptions>(options =>
            {
                options.KeyPrefix = "Cache:";
            });

            // SwaggerGen
            List<DocApiInfo> infos = new List<DocApiInfo>();
            for (int i = 0; i < 10; i++)
            {
                var info = new DocApiInfo
                {
                    Name = configuration[$"SwaggerDoc:{i}:Name"]?.ToString(),
                    Title = configuration[$"SwaggerDoc:{i}:Title"]?.ToString(),
                    Description = configuration[$"SwaggerDoc:{i}:Description"]?.ToString()
                };

                if (info.Name != null && info.Title != null && info.Description != null)
                {
                    infos.Add(info);
                }
            }
            context.Services.AddSwaggerGen(infos.ToArray());

            // Cors
            context.Services.AddCors(options =>
            {
                options.AddPolicy(DefaultCorsPolicyName, builder =>
                {
                    builder.WithOrigins(
                            configuration["App:CorsOrigins"]
                                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                .Select(o => o.RemovePostFix("/"))
                                .ToArray()
                        )
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            // Mvc
            Configure<MvcOptions>(options =>
            {
                // remove AbpNoContentActionFilter
                int index = options.Filters.FindIndex(filter => filter is ServiceFilterAttribute attr &&
                        attr.ServiceType.Equals(typeof(AbpNoContentActionFilter)));
                if (index > -1) options.Filters.RemoveAt(index);

                // remove AbpExceptionFilter
                index = options.Filters.FindIndex(filter => filter is ServiceFilterAttribute attr &&
                        attr.ServiceType.Equals(typeof(AbpExceptionFilter)));

                if (index > -1) options.Filters.RemoveAt(index);

                // add DakExceptionFilter
                options.Filters.Add(typeof(DakExceptionFilter));

                // add DakWrapResultActionFilter
                options.Filters.Add(typeof(DakWrapResultActionFilter));
            });

            // Json Format
            Configure<AbpJsonOptions>(options =>
            {
                options.DefaultDateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
            var configuration = context.GetConfiguration();

            app.UseVirtualFiles();

            app.UseRouting();

            app.UseCors(DefaultCorsPolicyName);

            app.UseAuthentication();

            //app.UseAbpClaimsMap();

            //if (MultiTenancyConsts.IsEnabled)
            //{
            //    app.UseMultiTenancy();
            //}

            app.UseAbpRequestLocalization();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                for (int i = 0; i < 10; i++)
                {
                    var name = configuration[$"SwaggerDoc:{i}:Name"]?.ToString();
                    var title = configuration[$"SwaggerDoc:{i}:Title"]?.ToString();
                    var description = configuration[$"SwaggerDoc:{i}:Description"]?.ToString();

                    if (name != null && title != null && description != null)
                    {
                        options.SwaggerEndpoint($"/swagger/{name}/swagger.json", name);
                    }
                }
            });

            //app.UseAuditing();

            app.UseAbpSerilogEnrichers();

            app.UseConfiguredEndpoints();
        }
    }
}