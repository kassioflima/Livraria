using Livraria.Domain.UseCases.Livros.Dto;
using Livraria.Domain.UseCases.Livros.Entity;
using Livraria.Domain.UseCases.Livros.Interfaces.Application;
using Livraria.Domain.UseCases.Livros.Interfaces.Repository;
using Livraria.Domain.UseCases.Livros.Mapper;
using Microsoft.Extensions.Logging;

namespace Livraria.Application.UseCases.Livros
{
    public class LivroAlterarApplication(ILogger<LivroAlterarApplication> _logger, ILivroRepository _repository) : ILivroAlterarApplication
    {
        public async Task<bool> HandleAsync(LivroDto livro)
        {
            _logger.LogInformation("Iniciando cadastro da editora.");
            var entity = new Livro(livro.Titulo, livro.Autor, livro.Lancamento, livro.Capa, livro.CategoriaId, livro.EditoraId, livro.Situacao);
            return await _repository.Atualizar(entity);
        }
    }
}
