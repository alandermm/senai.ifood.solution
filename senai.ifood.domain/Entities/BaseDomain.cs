using System;
using System.ComponentModel.DataAnnotations;

namespace senai.ifood.domain.Entities
{
    public abstract class BaseDomain
    {
        [Key]
        [DatabaseGenerated[DatabaseGeneratedOption.Identity]]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }
    }
}