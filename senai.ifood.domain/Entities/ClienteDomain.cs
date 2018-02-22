using System;
using System.ComponetModel.DataAnnotations;

namespace senai.ifood.domain.Entities
{
    public class ClienteDomain:BaseDomain
    {
        [Required]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string sexo { get; set; }

        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}