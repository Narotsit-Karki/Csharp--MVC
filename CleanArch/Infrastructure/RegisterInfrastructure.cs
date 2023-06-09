﻿using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class RegisterInfrastructure
    {
        public static void AddInfrastructure(IServiceCollection services,IConfiguration configuration)

        {// very necesary for migrations
            services.AddDbContext<IEDbcontext, EDbcontext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ECOMMERCE"),b => b.MigrationsAssembly("API"));
            });
        }
    }
}
