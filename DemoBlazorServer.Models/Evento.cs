namespace DemoBlazorServer.Models;

public class Evento
{
    public int Id { get; set; }
    public required string Nome { get; set; } 
    public required string Località { get; set; }
    public DateTime Data { get; set; }
}
