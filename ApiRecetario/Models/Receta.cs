using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRecetario.Models
{
    public partial class Receta
    {
        [Key]
        public int RecetaId { get; set; }
        public string NombreDeReceta { get; set; }
        public string Ingredientes { get; set; }
        public string Preparacion { get; set; }
        public string TiempoDePreparacion { get; set; }
        public int Porciones { get; set; }
        /*[Url]
        public int Imagen { get; set; }*/
    }
}
