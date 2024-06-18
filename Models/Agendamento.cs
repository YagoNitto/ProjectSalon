using System.ComponentModel.DataAnnotations;

namespace ProjectSalonV2.Models;

public class Agendamento
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe o nome")]
    public string NomeCompleto { get; set; } = string.Empty;
    [Required(ErrorMessage = "Informe o número do celular")]
    public string Celular { get; set; } = string.Empty;
    [Required(ErrorMessage = "Informe uma data")]
    public DateOnly Data { get; set; }
    [Required(ErrorMessage = "Informe um horário")]
    public string Hora { get; set; } = string.Empty;
    [Required(ErrorMessage = "Informe uma forma de pagamento")]
    public string FormaPagamento { get; set; } = string.Empty;
}
