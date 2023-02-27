using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Dtos
{
    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string NombreCompleto { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int IdDepartamento { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int Sueldo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        public DateTime FechaContrato { get; set; }

        public DepartamentoDTO? Departamento { get; set; }

    }
}
