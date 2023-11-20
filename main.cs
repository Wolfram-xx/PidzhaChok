
// Class "EducationalInstitution" (Учебное заведение)
public class EducationalInstitution
{
    public string Name { get; set; }
    public string Address { get; set; }
    // Other properties as needed

    // Relationships
    public ICollection<EducationalPlan> EducationalPlans { get; set; }
}

// Class "EducationalPlan" (Учебный план)
public class EducationalPlan
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    // Relationships
    public EducationalProgram EducationalProgram { get; set; }
    public ICollection<Discipline> Disciplines { get; set; }
    public ICollection<Student> Students { get; set; }
}

// Class "Discipline" (Дисциплина)
public class Discipline
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int AcademicHours { get; set; }
    public string Prerequisites { get; set; }

    // Relationships
    public Teacher Teacher { get; set; }
    public EducationalPlan EducationalPlan { get; set; }
}

// Class "EducationalProgram" (Образовательная программа)
public class EducationalProgram
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string EducationLevel { get; set; }

    // Relationships
    public EducationalInstitution EducationalInstitution { get; set; }
    public ICollection<EducationalPlan> EducationalPlans { get; set; }
}

// Class "Teacher" (Преподаватель)
public class Teacher
{
    public string Name { get; set; }
    // Other properties as needed

    // Relationships
    public ICollection<Discipline> TaughtDisciplines { get; set; }
}

// Class "Student" (Студент)
public class Student
{
    public string Name { get; set; }
    // Other properties as needed

    // Relationships
    public EducationalPlan EducationalPlan { get; set; }
}

