namespace Modulo05.ServiceLifetime.Services;

public class ContadorSingletonService : IContadorService
{
    private int _contador;
    // public int Incrementar() => ++_contador;
    public int Incrementar()
    {
    ++_contador;
    return _contador;

    } 
    
}