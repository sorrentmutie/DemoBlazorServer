using System.ComponentModel.DataAnnotations;

namespace DemoBlazorServer.Models;

public class Evento
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Il nome è obbligatorio")]
    [StringLength(10, ErrorMessage = "Il nome non può superare i 50 caratteri")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "La localita è obbligatoria")]
    public string? Località { get; set; }
    public DateTime Data { get; set; }
}
