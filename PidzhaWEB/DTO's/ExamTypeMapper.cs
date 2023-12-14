using Pidzha.Domain;

namespace PidzhaWEB.DTO_s
{
    public class ExamTypeMapper
    {
        public static ExamTypeDto ToDto(ExamType examType)
        {
            var examTypeDto = new ExamTypeDto
            {
                ID = examType.ID,
                Name = examType.Name
            };
            return examTypeDto;
        }

        public static ExamType ToEntity(ExamTypeDto examTypeDto)
        {
            var examType = new ExamType
            {
                ID = examTypeDto.ID,
                Name = examTypeDto.Name
            };
            return examType;
        }
    }
}
