using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ParishApi.Entity;
using ParishApi.Interface;
using ParishApi.ParishData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddDbContextPool<ParishContext>
               (options => options.UseSqlServer(Configuration.GetConnectionString("ParishContextConnectionString")));

            services.AddScoped<IMemberData, MemberData>();
            services.AddScoped<IFamilyMemberData, MemberFamilyData>();
            services.AddScoped<IUserLoginData, UserLoginData>();
            services.AddScoped<IDocumentData, DocumentData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
