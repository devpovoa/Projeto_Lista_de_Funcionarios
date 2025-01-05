using System.Text.Json.Serialization;

namespace Server_Side.Enums
{
 [JsonConverter(typeof(JsonStringEnumConverter))]
 public enum DepartamentoEnum
 {
  RH,
  Financeiro,
  Contabil,
  Compras,
  Vendas,
  Logistica,

 }

}

