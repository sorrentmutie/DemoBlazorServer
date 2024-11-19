namespace DemoBlazorServer.Models;

public interface IEventi
{
    List<Evento> EstraiEventiPassati();
    List<Evento> EstraiEventiFuturi();
    string EstraiTesto();
}
