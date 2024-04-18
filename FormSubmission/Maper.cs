using AutoMapper;
using FormSubmission.DTOs;
using FormSubmission.Model;

namespace FormSubmission
{
    public class Maper:Profile
    {
        public Maper()
        {
            CreateMap<Students,StudentDTO>().ReverseMap();
        }

    }
}
