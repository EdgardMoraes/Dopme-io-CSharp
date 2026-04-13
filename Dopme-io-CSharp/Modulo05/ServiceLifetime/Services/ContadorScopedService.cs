namespace Modulo05.ServiceLifetime.Services;

public class ContadorScopedService : IContadorService
{
    private int _contador;
    public int Incrementar() => ++_contador;
    
}