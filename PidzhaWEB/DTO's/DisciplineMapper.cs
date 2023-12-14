using Pidzha.Domain;

namespace PidzhaWEB.DTO_s
{
    public class DisciplineMapper
    {
        public static DisciplineDto ToDto(Discipline discipline)
        {
            var disciplineDto = new DisciplineDto
            {
                Name = discipline.Name,
                Hours = discipline.Hours
            };
            return disciplineDto;
        }

        public static Discipline ToEntity(DisciplineDto disciplineDto)
        {
            var discipline = new Discipline
            {
                Name = disciplineDto.Name,
                Hours = disciplineDto.Hours
            };
            return discipline;
        }
    }
}
