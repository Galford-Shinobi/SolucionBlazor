using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Dtos
{
    public class DepartamentoDTO
    {
        public int IdDepartamento { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; } = null!;

    }
}
