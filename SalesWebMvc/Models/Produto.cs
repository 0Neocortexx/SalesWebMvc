namespace SalesWebMvc.Models {
    public class Produto {
        public int id {get; set;}
        public string? nome { get; set;}

        /// <summary>
        /// O ? apos o atributo define que o atributo pode ser nullable, ou seja, pode ser anulavel ou vazio
        /// Por padrão ele será obrigatório, ou required
        /// </summary>
        public float? valor { get; set;}
    }
}
