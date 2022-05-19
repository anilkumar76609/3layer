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
    public class CampusService : ICampus
    {
        private readonly StudyContext _StudyContext;
        public CampusService(StudyContext StudyContext)
        {
            _StudyContext = StudyContext;
        }
        public List<Campus> GetCampuses()
        {
            return _StudyContext.Campuses.ToList();

        }
        public Campus Get(int id)
        {
            return _StudyContext.Campuses.FirstOrDefault(x => x.Id == id);

        }
        public void Post(Campus Campus)
        {
            _StudyContext.Campuses.Add(Campus);
            _StudyContext.SaveChanges();
        }
        public Campus Put(Campus Campus, int CampusId)
        {
            Campus CampusToUpdate = _StudyContext.Campuses.Where(x => x.Id == CampusId).FirstOrDefault();
            
            CampusToUpdate.CampusId = Campus.CampusId;
            CampusToUpdate.FirstName = Campus.FirstName;
            CampusToUpdate.LastName = Campus.LastName;
            _StudyContext.SaveChanges();
            return CampusToUpdate;
        }
        public void Delete(Campus Campus)
        {
            _StudyContext.Campuses.Remove(Campus);
            _StudyContext.SaveChanges();
        }

        
    }
}