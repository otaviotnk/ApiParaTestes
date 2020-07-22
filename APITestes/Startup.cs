using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using APITestes.Data;
using Microsoft.AspNetCore.Mvc.Cors;

namespace APITestes
{
    public class Startup
    {
        readonly string origemDoAngular = "_origemDoAngular";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //Adicionando o CORS para o Angular
            //Chamar sempre antes do UseMVC
            services.AddCors(options =>
            {
                options.AddPolicy(name: origemDoAngular, builder =>
                {
                    //Habilita todos os Headers e métodos, é possível personalizar
                    //Habilita o CORS somente do localhost:4200
                    builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddControllers();

            services.AddDbContext<APITestesContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("APITestesContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //Habiitando o CORS, deve ser colocada depois do Routing e antes do Authorization
            app.UseCors(origemDoAngular);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });            
        }
    }
}
