using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_BaseLayer.Models
{
    public class Principal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mobileno { get; set; }
        [ForeignKey("Campus(Id)")]
        public int CampusId { get; set; }

    }
}
