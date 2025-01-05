using Server_Side.Models;

namespace Server_Side.Service.FuncionarioService
{
 public interface IFuncionarioInterface
 {
  Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
  Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
  Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionarios(FuncionarioModel novoFuncionario);
  Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
  Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
  Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
 }

}

