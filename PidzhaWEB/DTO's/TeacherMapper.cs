using Pidzha.Domain;

namespace PidzhaWEB.DTO_s
{
    public class TeacherMapper
    {
        public static TeacherDto ToDto(Teacher teacher)
        {
            var teacherDto = new TeacherDto
            {
                Name = teacher.Name
            };
            return teacherDto;
        }

        public static Teacher ToEntity(TeacherDto teacherDto)
        {
            var teacher = new Teacher
            {
                Name = teacherDto.Name
            };
            return teacher;
        }
    }
}
