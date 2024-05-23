namespace parcial4
{
    public class Libro
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public string Genero { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            FechaPublicacion = DateTime.Now;
        }
    }
}
