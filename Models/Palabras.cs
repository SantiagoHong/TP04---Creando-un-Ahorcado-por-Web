namespace TP04_Ahorcado.Models;

public class Palabras
{
    public string palabra { get; private set; }
    public List<char> letras { get; private set; }

    public Palabras (string palabra, List<char> letras)
    {
        this.palabra = palabra;
        this.letras = letras;
    }
}