using System.Text.Json.Serialization;

namespace WebAPI_Funcionario.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite,
        Integral
    }
}
