namespace TP04_Ahorcado.Models;

public class Juego
{
    public static string palabra { get; private set; } = "murcielago";
    public static int intentos = 0;
    public static List<char?> letrasUsadas { get; private set; } = new List<char?>();
    

    public static int DevolverPalabraComp(string palabraRes)
    {
        int resultado;
        if(palabraRes == palabra)
        {
            resultado = 1;
        }
        else
        {
            resultado = -1;
        }
    return resultado;
    }
    public static string devolverPalabra(char? letra)
    {
        string nuevaPalabra = palabra;
        if (letra.HasValue)
        {
            List<char> LBuscada = buscarLetra(letra);

            for(int i = 0; i < LBuscada.Count; i++)
            {
                nuevaPalabra = palabra.Replace(palabra[i], '_');
            }
        }
        else
        {
            for(int i = 0; i < palabra.Length; i++)
            {
                nuevaPalabra = palabra.Replace(palabra[i], '_');
            }
        }
        
        return nuevaPalabra;
    }

    public static void agregarLetrasUsadas(char? letra)
    {
        letrasUsadas.Add(letra);
    }

    private static List<char> buscarLetra(char? letra)
    {
        List<char> LBuscada = new List<char>();
        int i = 0;

        while(i < palabra.Length)
        {
            if (letra != palabra[i])
            {
                LBuscada.Add(palabra[i]);
            }
            i++;
        }
        return LBuscada;
    }

    public static bool buscarLetrasUsadas(char? letra)
    {
        int i = 0;
        bool existe = false;

        while(i < palabra.Length && letrasUsadas[i] != letra)
        {
            i++;
        }

        if (i == palabra.Length)
        {
            existe = true;
        }
        return existe;
    }

}