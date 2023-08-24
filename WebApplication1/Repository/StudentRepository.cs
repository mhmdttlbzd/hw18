using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _DbContext;
        public StudentRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        private IQueryable<Student> GetAllQuery()
        {
            var res = _DbContext.Students;
            return res;
        }
        private List<StudentModel> Map(IQueryable<Student> query) 
        {
            var res = query.Select(p => new StudentModel
            {
                id = p.id,
                FullName = p.Name + " " + p.Family,
                Lessons = p.Lessons.Select(x => x.Tittle.ToString()).ToList(),
                Addresse = p.State.Name + " - " + p.Address.City + " - " + p.Address.Street,
                Professors = p.Lessons.Select(x => x.Professor.Name.ToString() + x.Professor.Family.ToString()).ToList()
            }).ToList();
            return res;
        }
        public List<StudentModel> GetAll() 
        {
            return Map(GetAllQuery());
        }
        public List<StudentModel> GetAllByState()
        {
            return Map(GetAllQuery().OrderBy(s => s.StateId));
        }
        public List<Lesson> DontGetLesson(int id)
        {
            List<Lesson> l = GetAllQuery().Where(s => s.id == id).Include(s => s.Lessons).Select(m => m.Lessons).FirstOrDefault();
            List<Lesson> res = _DbContext.Lessons.ToList().Except(l).ToList();
            return res;
        }
        public List<lessonMode> GetAllLessonModel()
        {
            var res = _DbContext.Lessons.OrderBy(l => l.Tittle).Select(l => new lessonMode
            {
                Tittle = l.Tittle,
                Course = l.Course,
                ProfessorName = l.Professor.Name + " " + l.Professor.Family,
                StudentLenth = l.Students.Count()
            }).ToList();
            return res;
        }
    }
}
