namespace Modulo05.ServiceLifetime.Services;

public class ContadorTransienteService : IContadorService
{
    private int _contador;
    public int Incrementar() => ++_contador;
}