using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Win02.Modelo
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 2)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public string TipoContrato { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }
}
