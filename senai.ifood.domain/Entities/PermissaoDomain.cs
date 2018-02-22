using System.Collections.Generic;
namespace senai.ifood.domain.Entities
{
    public class PermissaoDomain:BaseDomain
    {
        public string Nome { get; set; }

        public ICollection<UsuarioPermissaoDomain> UsuarioPermissoes { get; set; }
    }
}