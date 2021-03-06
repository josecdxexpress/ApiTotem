﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDX.Totem.Domain.Infraestrutura.Conexao;
using CDX.Totem.Domain.Repository;
using CDX.Totem.Domain.Repository.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using CDX.Totem.Core.Infraestrutura.Interfaces;
//using Microsoft.Extensions.Options;
using CDX.Totem.Domain.Models.To.Extensoes;
using CDX.Totem.Core.Infraestrutura.Persistence;
using CDX.Totem.Core.Infraestrutura.Services;
using CDX.Totem.Domain.Services.Interface;
using CDX.Totem.Domain.Services;

namespace CDX.Totem.Api
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
            #region Banco de dados
            var conexaoConn = @"Data Source=DESKTOP-TSM74VM\SQLEXPRESS;Initial Catalog=CDXTOTEM;Integrated Security=True;";

            services.AddDbContextPool<Contexto>(opt =>
                opt.UseSqlServer(conexaoConn, x => x.MigrationsAssembly("CDX.Totem.Domain")));
            #endregion

            #region Injeção de Dependência - Principal
            services.AddTransient<IUow, Uow>();
            #endregion

            #region Services
            //services.AddTransient<IEntidadeAuditada>();
            //services.AddTransient<IEntidadeAuditada, EntidadeBase<>>();
            //services.AddTransient<ICdxEntityService, CdxEntityService>();
            //serviceCollection.AddInstance<ILoggerFactory>(loggerFactory);

            // builder
            //.RegisterGeneric(typeof(GenericRepository<,>))
            //.As(typeof(IRepository<,>))
            //.InstancePerLifetimeScope();
            //services.AddTransient<ICdxEntityService<Livro, int>, CdxEntityService<Livro, int>>();
            //services.AddTransient<IRepository<Livro, int>, GenericRepository<Livro, int>>();
            //services.AddTransient<GenericRepository<Livro, int>, IRepository<Livro, int>>();
            //services.AddTransient<IXDbxService, XDbxService>();
            //services.AddTransient<IParametrosService, ParametrosService>();
            //services.AddTransient<IUsuarioService, UsuarioService>();
            //services.AddTransient<INotaFiscalService, NotaFiscalService>();
            //services.AddTransient<IMobLinkService, MobLinkService>();
            services.AddTransient<ITotemService, TotemService>();
            #endregion

            #region Repositorios
            //services.AddTransient<ICidadeNfeRepository, CidadeNfeRepository>();
            //services.AddTransient<INotaFiscalRepository, NotaFiscalRepository>();
            //services.AddTransient<IRequisicaoRepository, RequisicaoRepository>();
            //services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            //services.AddTransient<IParametrosRepository, ParametrosRepository>();
            //services.AddTransient<INotaFiscalAutorizadaRepository, NotaFiscalAutorizadaRepository>();
            //services.AddTransient<INotaFiscalSolicitadaRepository, NotaFiscalSolicitadaRepository>();

            services.AddTransient<ITotemRepository, TotemRepository>();
            #endregion

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddContext(LogLevel.Information, Configuration.GetConnectionString("LoggerDatabase"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseMvc();
        }
    }
}
