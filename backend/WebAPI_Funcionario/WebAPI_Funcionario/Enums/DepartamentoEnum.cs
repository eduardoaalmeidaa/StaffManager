using System.Text.Json.Serialization;

namespace WebAPI_Funcionario.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        Administrativo,
        Comercial,
        Compras,
        Contabilidade,
        Financeiro,
        Juridico,
        Logistica,
        Marketing,
        RH,
        Suporte,
        TI
    }
}