using FormSubmission.DTOs;
using FormSubmission.Model;

namespace FormSubmission.Services
{
    public class StudentService: IStudentService
    {
        private readonly FormSubmission.StudentContext.StudentsContext studentbd;
        public StudentService(FormSubmission.StudentContext.StudentsContext students ) 
        { 
            this.studentbd = students;
        }



        public List<Students> listAllStudents()
        {
            return studentbd.students.ToList();
        } 



        public bool AddStudent(StudentDTO student)
        {
            try
            {
                Students students = new Students();
                students.Name = student.Name;
                students.Age = student.Age;

                studentbd.Add(students);
                studentbd.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }



        public bool Delete(int id)
        {
            try
            {
                var studet = studentbd.students.Find(id);
                if( studet == null ) 
                {
                    throw new Exception("user not found");
                }
                studentbd.Remove(studet);
                studentbd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }



        public bool Update(int id,StudentDTO student)
        {
            try
            {
                var studet = studentbd.students.Find(id);
                if (studet == null)
                {
                    throw new Exception("user not found");

                }
                studet.Name = student.Name;
                studet.Age = student.Age;
                studet.isUpdateneeded = student.isUpdateneeded;
                studentbd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
