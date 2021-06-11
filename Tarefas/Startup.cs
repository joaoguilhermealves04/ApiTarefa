using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region configuração dO Swagger 
            //services.AddSwaggerGen(s =>
            //{
            //    new OpenApiInfo
            //    {
            //        Title = "Acesso De Arquivos de Fucionario",
            //        Version = "v1",
            //        Description = "Sistema desenvolvido em NET CORE API com Dapper",
            //        Contact = new OpenApiContact
            //        {
            //            Name = "RhFuncionario",
            //            Url = new Uri("http://www.RHFuncionario.com.br"),
            //            Email = "Rhfuncionario@gmail.com.br"
            //        }

            //    };
            //});
            #endregion
            
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
            #region configuração do Swagger

            //app.UseSwagger();
            //app.UseSwaggerUI(s => s.SwaggerEndpoint("/swagger/v1/swagger.json", "projeto"));
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
