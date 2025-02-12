using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server_Side.Models;
using Server_Side.Service.FuncionarioService;

namespace Server_Side.Controllers
{
 [Route("api/[controller]")]
 [ApiController]
 public class FuncionarioController : ControllerBase
 {
  private readonly IFuncionarioInterface _funcionarioInterface;
  public FuncionarioController(IFuncionarioInterface funcionarioInterface)
  {
   _funcionarioInterface = funcionarioInterface;
  }

  [HttpGet]
  public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
  {
   return Ok(await _funcionarioInterface.GetFuncionarios());
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionarioById(int id)
  {
   ServiceResponse<FuncionarioModel> serviceResponse = await _funcionarioInterface.GetFuncionarioById(id);
   return Ok(serviceResponse);
  }

  [HttpPost]
  public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionarios(FuncionarioModel novoFuncionario)
  {
   return Ok(await _funcionarioInterface.CreateFuncionarios(novoFuncionario));
  }

  [HttpPut]
  public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
  {
   ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncionario(editadoFuncionario);
   return Ok(serviceResponse);
  }

  [HttpPut("InativaFuncionario")]
  public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
  {
   ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);
   return Ok(serviceResponse);
  }

  [HttpDelete]
  public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
  {
   ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncionario(id);
   return Ok(serviceResponse);
  }
 }
}
