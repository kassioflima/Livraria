using Livraria.Domain.Shared.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.UseCases.Editoras.Query
{
    public record EditoraQuery
    {
        public int? Id { get; set; }
        public ESituacao? Situacao { get; set; }
        public string? Nome { get; set; }
    }
}
