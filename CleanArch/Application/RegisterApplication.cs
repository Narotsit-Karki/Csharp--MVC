using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RegisterApplication
    {
        public static void AddApplication(IServiceCollection services) //IServiceCollection is Ioc Contaioners
        {
            services.AddScoped<IBrandServices, BrandServices>();
        }
    }
}
