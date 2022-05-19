using Business_Logic__Layer.Interface;
using Data_BaseLayer;
using Data_BaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic__Layer.BLL
{
    public class PrincipalService : IPrincipal
    {
        private readonly StudyContext _StudyContext;
        public PrincipalService(StudyContext StudyContext)
        {
            _StudyContext = StudyContext;
        }
        public List<Principal> GetPrincipals()
        {
            return _StudyContext.Principals.ToList();
        }
        public Principal Get(int id)
        {
            return _StudyContext.Principals.FirstOrDefault(x => x.Id == id);
        }
        public void Post(Principal Principal)
        {
            _StudyContext.Principals.Add(Principal);
            _StudyContext.SaveChanges();
        }
        public Principal Put(Principal Principal, int id)
        {
            Principal PrincipalToUpdate = _StudyContext.Principals.Where(x => x.Id == id).FirstOrDefault();
            PrincipalToUpdate.Id = id;
            PrincipalToUpdate.Name = Principal.Name;
            PrincipalToUpdate.Mobileno = Principal.Mobileno;
            _StudyContext.SaveChanges();
            return PrincipalToUpdate;
        }
        public void Delete(Principal Principal)
        {
            _StudyContext.Principals.Remove(Principal);
            _StudyContext.SaveChanges();
        }
    }
}
