using FormSubmission.DTOs;
using FormSubmission.Model;

namespace FormSubmission.Services
{
    public interface IStudentService
    {
        List<Students> listAllStudents();
        bool AddStudent(StudentDTO student);
        bool Delete(int id);
        bool Update(int id, StudentDTO student);

    }
}
