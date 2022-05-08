using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RetroShirt.Business.Abstract;
using RetroShirt.Business.Concrete;
using RetroShirt.Business.MapperProfile;
using RetroShirtDAL.Data;
using RetroShirtDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RetroShirtWeb
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
            services.AddControllersWithViews();         
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<ICategoryTeamService,CategoryTeamService>();
            services.AddScoped<ITeamService,TeamService>();
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IMailService,MailService>();
           
            
            
            services.AddScoped<ITeamRepository, EFTeamRepository>();
            services.AddScoped<IProductRepository,EFProductRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<ICategoryTeamRepository, EFCategoryTeamRepository>();
            services.AddScoped<IUserRepository, EFUserRepository>();
           
            

            var connectionString = Configuration.GetConnectionString("db");
            services.AddDbContext<RetroShirtDBContext>(opt => opt.UseSqlServer(connectionString));

            services.AddAutoMapper(typeof(MapProfile));

            services.AddSession();
            

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
                opt.LoginPath = "/Users/Login";
                opt.AccessDeniedPath = "/Users/AccessDenied";

            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "KatPage",
                   pattern: "category{catId}/page{currentPage}",
                   defaults: new { controller = "Home", action = "Index", catId = 0, currentPage = 1 });

                endpoints.MapControllerRoute(
                  name: "Kat",
                  pattern: "category{catId}",
                  defaults: new { controller = "Home", action = "Index", catId = 0 });

                endpoints.MapControllerRoute(
               name: "Page",
               pattern: "page{currentPage}",
               defaults: new { controller = "Home", action = "Index", currentPage = 1 });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

