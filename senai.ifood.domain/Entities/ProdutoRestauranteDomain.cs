namespace senai.ifood.domain.Entities
{
    public class ProdutoRestauranteDomain:BaseDomain
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Boolean Ativo { get; set; }
        public decimal Valor { get; set; }
        
        public RestauranteDomain Restaurante { get; set; }
        public int RestauranteId { get; set; }
    }
}