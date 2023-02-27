using BlazorCrud.Shared.Dtos;

namespace BlazorCrud.Client.Utilities.Services
{
    public interface IDepartamentoService
    {
        Task<List<DepartamentoDTO>> Lista();
    }
}
