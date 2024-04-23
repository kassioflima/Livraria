using Livraria.Domain.Shared.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Domain.UseCases.Cagetorias.Dto
{
    public record CategoriaDto
    {
        public int CategoriaId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a descrição da categoria."), StringLength(150)]
        public string? DescricaoCategoria { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a descrição da categoria."), StringLength(150)]
        public string? Descricao { get; set; }

        [EnumDataType(typeof(ESituacao), ErrorMessage = "Selecione a situação do livro.")]
        public ESituacao Situacao { get; set; }
    }
}
