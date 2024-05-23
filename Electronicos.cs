namespace parcial4
{
    public class Electronicos:Libro
    {
        public string Formato {  get; set; }
        public int Tamannio { get; set; }

        public Electronicos() 
        {
            Formato = string.Empty;
            Tamannio = 0;
        }
    }
}
