using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APITestes.Models
{
    public class Curso
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido.")]
        [MaxLength(100, ErrorMessage = "O titulo do curso so pode conter ate {1} caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido.")]        
        public int CargaHoraria { get; set; }
       
        public virtual ICollection<Aula> Aulas { get; set; }



    }
}
