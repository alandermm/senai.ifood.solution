using System.Collections.Generic;
namespace senai.ifood.domain.Entities
{
    public class RestauranteDomain:BaseDomain
    {
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Site { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public EspecialidadeDomain Especialidade { get; set; }
        public int EspecialidadeId { get; set; }

        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<ProdutoRestauranteDomain> ProdutosRestaurante { get; set; }

    }
}