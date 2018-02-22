using System;
using System.ComponetModel.DataAnnotations;

namespace senai.ifood.domain.Entities
{
    public class ClienteDomain:BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(20)]
        public string sexo { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        
        public int UsuarioId { get; set; }
    }
}