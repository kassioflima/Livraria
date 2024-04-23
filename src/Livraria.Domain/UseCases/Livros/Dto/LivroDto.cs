using Livraria.Domain.Shared.Domain.Enum;
using Livraria.Domain.UseCases.Cagetorias.Dto;
using Livraria.Domain.UseCases.Editoras.Dto;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Domain.UseCases.Livros.Dto
{
    public record LivroDto
    {
        public int LivroId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o autor do livro."), StringLength(150)]
        public string? Titulo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o autor do livro."), StringLength(200)]
        public string? Autor { get; set; }
        public DateTime Lancamento { get; set; } = DateTime.Now;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a imagem da capa do livro."), StringLength(300)]
        public string? Capa { get; set; }

        [EnumDataType(typeof(ESituacao), ErrorMessage = "Selecione a situação do livro.")]
        public ESituacao Situacao { get; set; } = ESituacao.Ativo;

        public int CategoriaId { get; set; }

        public int EditoraId { get; set; }

        public CategoriaDto? Categoria { get; set; }
        public EditoraDto? Editora { get; set; }
    }
}
