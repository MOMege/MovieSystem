﻿using Application.Repository;
using Infrastructure.Presistance.Data;
using Infrastructure.Presistance.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistance.Configrations
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddDbContext<DbcontextApplication>(options =>
   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            return services;
        }

        public static WebApplication UseInfrastructureServices(this WebApplication app)
        {


            return app;
        }
    }
}
