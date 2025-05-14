namespace TP04_Ahorcado.Models;

public class Respuesta
{
    public static Palabras respuesta;

    public static void InicializarRespuesta()
    {
        respuesta = new Palabras("murcielago", new List<char> {'m', 'u', 'r', 'c', 'i', 'e', 'l', 'a', 'g', 'o'});
    }
}
