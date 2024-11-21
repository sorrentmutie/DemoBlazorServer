namespace DemoBlazorServer.Models;

public interface IEventi
{
    List<Evento> EstraiEventiPassati();
    List<Evento> EstraiEventiFuturi();
    string EstraiTesto();
    void AggiungiEvento(Evento evento);
    void ModificaEvento(Evento evento);
}
