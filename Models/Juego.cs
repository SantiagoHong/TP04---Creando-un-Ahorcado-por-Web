namespace TP04_Ahorcado.Models;

public class Juego
{
    public static string palabra { get; private set; }
    public static int intentos { get; private set; }
    
    public static void InicializarJuego ()
    {
        palabra = "murcielago";
        intentos = 0;
    }

}