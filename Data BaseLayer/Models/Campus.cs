using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_BaseLayer.Models
{
    public class Campus
    {
        [Key]
        public int CampusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Professor(Id)")]
        public int Id { get; set; }
        public ICollection<Professor> Professor { get; set; }
    }
}
