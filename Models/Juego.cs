namespace TP04_Ahorcado.Models;

public class Juego
{
    public static string palabra { get; private set; } = "murcielago";
    public static int intentos = 0;
    public static List<char?> letrasUsadas { get; private set; } = new List<char?>();
    public static List<char?> letrasCorrectas { get; private set; } = new List<char?>();
    public static string nuevaPalabra { get; private set; } = palabra;
    // public static List<char> nuevapal { get; private set; }
    
    // foreach (char letra in palabra)
    // {
    //     nuevapal.Add('_')
    // }
    // nuevapal[letraCorrectaIndex] = letraCorrecta



    public static int DevolverPalabraComp(string palabraRes)
    {
        int resultado;
        if (palabraRes == palabra)
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
        if (letra != null)
        {
            letrasCorrectas.Add(buscarLetra(letra));

            for (int i = 0; i < nuevaPalabra.Length; i++)
            {
                for (int j = 0; j < letrasCorrectas.Count; j++)
                {
                    if (palabra[i] != letrasCorrectas[j])
                    {
                        if(i > 0)
                        {
                            if(nuevaPalabra[i] == '_')
                            {
                                nuevaPalabra = nuevaPalabra.Replace(palabra[i], '_');
                            }
                        }
                        else
                        {
                            nuevaPalabra = nuevaPalabra.Replace(palabra[i], '_');
                        }
                    }
                }
                
            }
        }
        else
        {
            int i = 0;
            nuevaPalabra = palabra.Replace(palabra[i], '_');

            for (i = 0; i < palabra.Length; i++)
            {
                nuevaPalabra = nuevaPalabra.Replace(palabra[i], '_');
            }
        }

        return nuevaPalabra;
    }

    public static void agregarLetrasUsadas(char? letra)
    {
        letrasUsadas.Add(letra);
    }

    private static char? buscarLetra(char? letra)
    {
        char? LBuscada;
        int i = 0;

        while (i < palabra.Length && palabra[i] != letra)
        {
            i++;
        }
        if (i == palabra.Length)
        {
            LBuscada = null;
        }
        else
        {
            LBuscada = palabra[i];
        }
        return LBuscada;
    }

    public static bool buscarLetrasUsadas(char? letra)
    {
        int i = 0;
        bool existe = false;

        if (letrasUsadas != null)
        {
            while (i < letrasUsadas.Count && letrasUsadas[i] != letra)
            {
                i++;
            }

            if (i == letrasUsadas.Count)
            {
                existe = true;
            }
        }

        return existe;
    }

}