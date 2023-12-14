using System.ComponentModel.DataAnnotations;

namespace Pidzha.Domain
{

    // Class "Discipline" (Дисциплина)
    public class Discipline
    {
        [Key]
        public string Name { get; set; } = null!;
        public string Hours { get; set; } = null!;

        // Relationships
        public Teacher Teacher { get; set; } = null!;

    }


    // Class "Teacher" (Преподаватель)
    public class Teacher
    {
        [Key]
        public string Name { get; set; } = null!;
        // Other properties as needed

        // Relationships
        public ICollection<Discipline> TaughtDisciplines { get; set; } = null!;
    }

    public class ExamType
    {
        [Key]
        public int ID { get; set; } = 0!;
        public string Name { get; set; } = null!;

        public ICollection<Discipline> TypeToGG { get; set; } = null!;
    }


}
