using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APITestes.Models
{
    public class Aula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido.")]
        [MaxLength(50, ErrorMessage = "O titulo da aula deve ter até {1} caracteres.")]
        [MinLength(10, ErrorMessage = "O titulo da aula deve ter no minimo {1} caracteres.")]
        public string Titulo { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "A ordem da aula deve ser maior que zero.")]
        public int Ordem { get; set; }

        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
