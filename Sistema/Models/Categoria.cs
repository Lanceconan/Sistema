using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Debe tener entre 3 y 50 caracteres")]
        public String Nombre { get; set; }
        [StringLength(256)]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
