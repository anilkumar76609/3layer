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
    public class ProfessorService : IProfessor
    {
        private readonly StudyContext _StudyContext;
        public ProfessorService(StudyContext StudyContext)
        {
            _StudyContext = StudyContext;
        }
        public List<Professor> GetProfessors()
        {
            return _StudyContext.Professors.ToList();
        }
        public Professor Get(int id)
        {
            return _StudyContext.Professors.FirstOrDefault(x => x.Id == id);
        }
        public void Post(Professor Professor)
        {
            _StudyContext.Professors.Add(Professor);
            _StudyContext.SaveChanges();
        }
        public Professor Put(Professor Professor, int id)
        {
            Professor ProfessorToUpdate = _StudyContext.Professors.Where(x => x.Id == id).FirstOrDefault();
            ProfessorToUpdate.Id = id;
            ProfessorToUpdate.Name = Professor.Name;
            ProfessorToUpdate.Experience = Professor.Experience;
            _StudyContext.SaveChanges();
            return ProfessorToUpdate;
        }
        public void Delete(Professor Professor)
        {
            _StudyContext.Professors.Remove(Professor);
            _StudyContext.SaveChanges();
        }

        
    }
}
