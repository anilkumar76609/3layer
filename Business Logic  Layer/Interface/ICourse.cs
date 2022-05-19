using Data_BaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic__Layer.Interface
{
    public interface ICourse
    {
        List<Course> GetCourses();
        Course Get(int id);
        void Post(Course Course);
        Course Put(Course Course, int id);
        void Delete(Course Course);
    }
}
