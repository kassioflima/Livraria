using Livraria.Domain.Shared.Domain.Enum;

namespace Livraria.Domain.Shared.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }
        public ESituacao Situacao { get; private set; }

        protected BaseEntity(int id, ESituacao situacao)
        {
            Id = id;
            Situacao = situacao;
        }

        protected BaseEntity(ESituacao situacao)
        {
            Situacao = situacao;
        }
    }
}
