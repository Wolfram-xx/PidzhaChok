namespace Pidzha.Domain
{

    // Class "EducationalInstitution" (Учебное заведение)
    public class EducationalInstitution
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        // Other properties as needed

        // Relationships
        public ICollection<EducationalPlan> EducationalPlans { get; set; } = null!;
    }

    // Class "EducationalPlan" (Учебный план)
    public class EducationalPlan
    {
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        // Relationships
        public EducationalProgram EducationalProgram { get; set; } = null!;
        public ICollection<Discipline> Disciplines { get; set; } = null!;
        public ICollection<Student> Students { get; set; } = null!;
    }

    // Class "Discipline" (Дисциплина)
    public class Discipline
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int AcademicHours { get; set; }
        public string Prerequisites { get; set; } = null!;

        // Relationships
        public Teacher Teacher { get; set; } = null!;
        public EducationalPlan EducationalPlan { get; set; } = null!;
    }

    // Class "EducationalProgram" (Образовательная программа)
    public class EducationalProgram
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string EducationLevel { get; set; } = null!;

        // Relationships
        public EducationalInstitution EducationalInstitution { get; set; } = null!;
        public ICollection<EducationalPlan> EducationalPlans { get; set; } = null!;
    }

    // Class "Teacher" (Преподаватель)
    public class Teacher
    {
        public string Name { get; set; } = null!;
        // Other properties as needed

        // Relationships
        public ICollection<Discipline> TaughtDisciplines { get; set; } = null!;
    }

    // Class "Student" (Студент)
    public class Student
    {
        public string Name { get; set; } = null!;
        // Other properties as needed

        // Relationships
        public EducationalPlan EducationalPlan { get; set; } = null!;
    }


}
