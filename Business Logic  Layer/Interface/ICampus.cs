using Data_BaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic__Layer.Interface
{
    public interface ICampus
    {
        List<Campus> GetCampuses();
        Campus Get(int id);
        void Post(Campus Campus);
        Campus Put(Campus Campus, int id);
        void Delete(Campus Campus);
    }
}