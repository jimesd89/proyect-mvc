namespace BlogMvc.Models
{
    public class Publicacion
    {
        public string Id { get; set; } = string.Empty;
        public string SubTitulo { get; set; } = string.Empty;
        public string Creador { get; set; } = string.Empty;
        public string Cuerpo { get; set; } = string.Empty;
        public DateTime Creacion { get; set; } = DateTime.Now;  
        public string Imagen { get; set; } = string.Empty;
    }
}
