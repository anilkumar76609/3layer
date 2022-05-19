using Data_BaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic__Layer.Interface
{
    public interface IPrincipal
    {
        List<Principal> GetPrincipals();
        Principal Get(int id);
        void Post(Principal Principal);
        Principal Put(Principal Principal, int id);
        void Delete(Principal Principal);
    }
}
