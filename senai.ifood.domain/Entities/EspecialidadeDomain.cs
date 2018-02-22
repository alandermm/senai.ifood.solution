using System.Collections.Generic;
namespace senai.ifood.domain.Entities
{
    public class EspecialidadeDomain:BaseDomain
    {
        public string Nome { get; set; }

        public ICollection<RestauranteDomain> Restaurantes { get; set; }
    }
}