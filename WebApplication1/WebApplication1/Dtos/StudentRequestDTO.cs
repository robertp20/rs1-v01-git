namespace WebApplication1.Dtos
{
    public class StudentRequestDTO
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }

        public DateOnly? DatumRodjenja { get; set; }
    }
}