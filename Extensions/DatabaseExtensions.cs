﻿
using Microsoft.EntityFrameworkCore;
using StudentTimeProject.Data;

namespace StudentTimeProject.Extention;

    public static class DatabaseExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();
        }
    }

