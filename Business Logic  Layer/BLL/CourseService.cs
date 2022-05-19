using Business_Logic__Layer.Interface;
using Data_BaseLayer;
using Data_BaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic__Layer.BLL
{
    public class CourseService : ICourse
    {
        private readonly StudyContext _StudyContext;
        public CourseService(StudyContext StudyContext)
        {
            _StudyContext = StudyContext;
        }
        public List<Course> GetCourses()
        {
            return _StudyContext.Courses.ToList();
        }
        public Course Get(int id)
        {
            return _StudyContext.Courses.FirstOrDefault(x => x.CourseId == id);
        }
        public void Post(Course Course)
        {
            _StudyContext.Courses.Add(Course);
            _StudyContext.SaveChanges();
        }
        public Course Put(Course Course, int CourseId)
        {
            Course CourseToUpdate = _StudyContext.Courses.Where(x => x.CourseId == CourseId).FirstOrDefault();

            CourseToUpdate.CourseId = Course.CourseId;
            CourseToUpdate.Name = Course.Name;
            CourseToUpdate.Cost = Course.Cost;
            _StudyContext.SaveChanges();
            return CourseToUpdate;
        }
        public void Delete(Course Course)
        {
            _StudyContext.Courses.Remove(Course);
            _StudyContext.SaveChanges();
        }
    }
}