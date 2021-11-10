using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRecetario.Models
{
    public partial class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
