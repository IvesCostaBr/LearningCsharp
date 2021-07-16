using System.ComponentModel.DataAnnotations;



namespace Main.API.models
{
    public class Eventos
    {

        [Key]
        public int EventoId { get; private set; }
        public string title { get; set; }
        public string local { get; set; }
        public string DataEvento { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImageUrl { get; set; }

    }
}