using DataAccess.DbContext;
using DataAccess.DbOperation;
using DataAccess.Interface.DbContext;
using DataAccess.Interface.DbOperation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcMovie.Data;
using Servcie.Interface;
using Servcie.Service;
using System.Data;

namespace MvcMovie
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

            services.AddDbContext<MvcMovieContext>(options 
                => options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            //services.AddScoped<IDbConnection, SqlConnection>(serviceProvider => {
            //    SqlConnection conn = new SqlConnection();
            //    //«ü¬£³s½u¦r¦ê
            //    conn.ConnectionString = Configuration.GetConnectionString("MvcMovieContext");
            //    return conn;
            //});

            //services.AddScoped<IMovieDbOperation, MovieDbOperation>();
            services.AddScoped<IMovieDbContext, MovieDbContext>();
            services.AddScoped<IMoviesService, MoviesService>();

     

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
