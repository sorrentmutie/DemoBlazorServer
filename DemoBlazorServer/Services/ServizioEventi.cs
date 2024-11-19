using DemoBlazorServer.Models;

namespace DemoBlazorServer.Services;


public class ServizioDummy : IEventi
{
    public List<Evento> EstraiEventiFuturi()
    {
        throw new NotImplementedException();
    }

    public List<Evento> EstraiEventiPassati()
    {
        throw new NotImplementedException();
    }

    public string EstraiTesto()
    {
        throw new NotImplementedException();
    }
}

public class ServizioEventi: IEventi
{
    public List<Evento> EstraiEventiPassati()
    {
        return new() {
         new Evento { Id = 1, Nome = "Evento 1", Data = DateTime.Now.AddDays(-1), Località = "Napoli" },
         new Evento { Id = 2, Nome = "Evento 2", Data = DateTime.Now.AddDays(-2), Località = "Roma" },
        };
    }


    public List<Evento> EstraiEventiFuturi()
    {
        return new() {
         new Evento { Id = 1, Nome = "Evento 3", Data = DateTime.Now.AddDays(1), Località = "Milano" },
         new Evento { Id = 2, Nome = "Evento 4", Data = DateTime.Now.AddDays(2), Località = "Torino" },
        };
    }

    public string EstraiTesto()
    {
        throw new NotImplementedException();
    }
}
