using Livraria.Application.UseCases.Categorias;
using Livraria.Application.UseCases.Editoras;
using Livraria.Application.UseCases.Livros;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Application;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Query;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Repository;
using Livraria.Domain.UseCases.Editoras.Interfaces.Application;
using Livraria.Domain.UseCases.Editoras.Interfaces.Query;
using Livraria.Domain.UseCases.Editoras.Interfaces.Repository;
using Livraria.Domain.UseCases.Livros.Interfaces.Application;
using Livraria.Domain.UseCases.Livros.Interfaces.Query;
using Livraria.Domain.UseCases.Livros.Interfaces.Repository;
using Livraria.Infrastructure.Context;
using Livraria.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //Application
            services.AddScoped<ICategoriaAlterarApplication, CategoriaAlterarApplication>();
            services.AddScoped<ICategoriaExcluirApplication, CategoriaExcluirApplication>();
            services.AddScoped<ICategoriaIncluirApplication, CategoriaIncluirApplication>();
            services.AddScoped<ICategoriaQuery, CategoriaQuery>();

            services.AddScoped<IEditoraAlterarApplication, EditoraAlterarApplication>();
            services.AddScoped<IEditoraExcluirApplication, EditoraExcluirApplication>();
            services.AddScoped<IEditoraIncluirApplication, EditoraIncluirApplication>();
            services.AddScoped<IEditoraQuery, EditoraQuery>();

            services.AddScoped<ILivroAlterarApplication, LivroAlterarApplication>();
            services.AddScoped<ILivroExcluirApplication, LivroExcluirApplication>();
            services.AddScoped<ILivroIncluirApplication, LivroIncluirApplication>();
            services.AddScoped<ILivroQuery, LivroQuery>();

            //Repository
            var connectionString = configuration.GetConnectionString("LivrariaConn");
            
            services.AddDbContext<LivrariaContext>(opt => opt.UseSqlServer(connectionString, x =>
            {
                x.MigrationsAssembly("Livraria.Infrastructure");
            }));

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IEditoraRepository, EditoraRepository>();
            services.AddScoped<ILivroRepository, LivroRepository>();

            return services;
        }
    }
}
