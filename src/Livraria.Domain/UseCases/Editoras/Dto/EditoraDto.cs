using Livraria.Domain.Shared.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.UseCases.Editoras.Dto
{
    public record EditoraDto
    {
        public int EditoraId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o nome da editora."), StringLength(150)]
        public string? Nome { get; set; }

        [EnumDataType(typeof(ESituacao), ErrorMessage = "Selecione a situação do livro.")]
        public ESituacao Situacao { get; set; }
    }
}
