using System;

namespace senai.ifood.domain.Entities
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}