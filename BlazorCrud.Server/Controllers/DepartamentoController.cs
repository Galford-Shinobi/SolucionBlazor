using BlazorCrud.Server.Entities;
using BlazorCrud.Shared.Dtos;
using BlazorCrud.Shared.Implementacions.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly DbcrudBlazorContext _dbcrudBlazorContext;

        public DepartamentoController(DbcrudBlazorContext dbcrudBlazorContext)
        {
            _dbcrudBlazorContext = dbcrudBlazorContext;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var responseApi = new ResponseAPI<List<DepartamentoDTO>>();
            var listaDepartamentoDTO = new List<DepartamentoDTO>();

            try
            {
                foreach (var item in await _dbcrudBlazorContext.Departamentos.ToListAsync())
                {
                    listaDepartamentoDTO.Add(new DepartamentoDTO
                    {

                        IdDepartamento = item.IdDepartamento,
                        Nombre = item.Nombre,
                    });
                }

                responseApi.EsCorrecto = true;
                responseApi.Valor = listaDepartamentoDTO;
            }
            catch (Exception ex)
            {

                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }

            return Ok(responseApi);
        }
    }
}
