using System.Text.Json.Serialization;

namespace Server_Side.Enums
{
 [JsonConverter(typeof(JsonStringEnumConverter))]
 public enum TurnoEnum
 {
  Manha,
  Tarde,
  Noite
 }
}