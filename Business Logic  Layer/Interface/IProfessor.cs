using Data_BaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic__Layer.Interface
{
    public interface IProfessor
    {
        List<Professor> GetProfessors();
        Professor Get(int id);
        void Post(Professor Professor);
        Professor Put(Professor Professor, int id);
        void Delete(Professor Professor);
    }
}
