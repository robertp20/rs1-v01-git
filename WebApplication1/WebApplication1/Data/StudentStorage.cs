using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentStorage
    {
        private readonly List<Student> _students = [];

        private int _sljedeciId = 1;

        public StudentStorage()
        {
            Dodaj(new Student()
            {
                Ime = "Robert",
                Prezime = "Pusic",
                BrojIndeksa = "IB220038",
                DatumRodjenja = new DateOnly(2003, 3, 19)
            });

            Dodaj(new Student()
            {
                Ime = "Adil",
                Prezime = "Joldic",
                BrojIndeksa = "IB26001",
                DatumRodjenja = new DateOnly(2000, 10, 19)
            });
        }

        public Student Dodaj(Student student)
        {
            student.Id = _sljedeciId++;
            student.DatumKreiranja = DateTime.UtcNow;
            _students.Add(student);

            return student;
        }

        public List<Student> GetAll()
        { return _students; }
    }
}