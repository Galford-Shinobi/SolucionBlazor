using BlazorCrud.Client.Utilities.Services;
using BlazorCrud.Shared.Dtos;
using BlazorCrud.Shared.Implementacions.Interfaces;
using System.Net.Http.Json;

namespace BlazorCrud.Client.Utilities.IServices
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly HttpClient _http;

        public DepartamentoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<DepartamentoDTO>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseAPI<List<DepartamentoDTO>>>("api/Departamento/Lista");

            if (result!.EsCorrecto)
                return result.Valor!;
            else
                throw new Exception(result.Mensaje);
        }
    }
}
