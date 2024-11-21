using DemoBlazorServer.Models;

namespace DemoBlazorWASM.Services;

public class ServizioEventiWASM : IEventi
{
    public List<Evento> EstraiEventiPassati()
    {
        return new() {
         new Evento { Id = 5, Nome = "Evento 5", Data = DateTime.Now.AddDays(-1), Località = "Napoli" },
         new Evento { Id = 6, Nome = "Evento 6", Data = DateTime.Now.AddDays(-2), Località = "Roma" },
        };
    }


    public List<Evento> EstraiEventiFuturi()
    {
        return new() {
         new Evento { Id = 7, Nome = "Evento 7", Data = DateTime.Now.AddDays(1), Località = "Milano" },
         new Evento { Id = 8, Nome = "Evento 8", Data = DateTime.Now.AddDays(2), Località = "Torino" },
        };
    }

    public string EstraiTesto()
    {
        throw new NotImplementedException();
    }

    public void AggiungiEvento(Evento evento)
    {
        throw new NotImplementedException();
    }

    public void ModificaEvento(Evento evento)
    {
        throw new NotImplementedException();
    }
}
