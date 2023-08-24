using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IStudentRepository
    {
        List<StudentModel> GetAll();
        List<StudentModel> GetAllByState();
        List<Lesson> DontGetLesson(int id);
    }
}
