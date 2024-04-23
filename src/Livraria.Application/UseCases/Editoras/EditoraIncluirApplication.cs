using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Cagetorias.Interfaces.Application;
using Livraria.Domain.UseCases.Editoras.Dto;
using Livraria.Domain.UseCases.Editoras.Entity;
using Livraria.Domain.UseCases.Editoras.Interfaces.Application;
using Livraria.Domain.UseCases.Editoras.Interfaces.Repository;
using Livraria.Domain.UseCases.Editoras.Mapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.UseCases.Editoras
{
    public class EditoraIncluirApplication(ILogger<EditoraIncluirApplication> _logger, IEditoraRepository _editoraRepository) : IEditoraIncluirApplication
    {
        public async Task<EditoraDto?> HandleAsync(EditoraDto editora)
        {
            _logger.LogInformation("Iniciando cadastro da editora.");
            var entity = new Editora(editora.Nome, editora.Situacao);
            var result = await _editoraRepository.AdicionarAsync(entity);
            return EditoraMapper.Map(result);
        }
    }
}
