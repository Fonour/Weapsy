﻿using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Weapsy.Api;
using Weapsy.Data.Reporting;
using Weapsy.Data.Repositories;
using Weapsy.Mvc.Apps;

namespace Weapsy.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var hostingEnvironment = services.BuildServiceProvider().GetService<IHostingEnvironment>();

            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ApiAutoMapperProfile());
                cfg.AddProfile(new DomainAutoMapperProfile());
                cfg.AddProfile(new ReportingAutoMapperProfile());

                foreach (var profile in AppLoader.Instance(hostingEnvironment).AppAssemblies.GetTypes<Profile>())
                {
                    cfg.AddProfile(profile);
                }
            });

            services.AddSingleton(sp => autoMapperConfig.CreateMapper());

            return services;
        }
    }
}
