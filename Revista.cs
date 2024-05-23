namespace parcial4
{
    public class Revista:Libro
    {
        public string Volumen { get; set; }
        public int NoEjemplar { get; set; }

        public Revista()
        { 
            Volumen = string.Empty;
            NoEjemplar = 0;
        }
    }
}
