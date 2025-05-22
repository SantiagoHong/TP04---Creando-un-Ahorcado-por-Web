namespace TP04_Ahorcado.Models;

public class Juego
{
    public static string palabra { get; private set; } = "murcielago";
    public static int intentos = 0;
    public static List<char> letrasUsadas { get; private set; } = new List<char>();
    public static List<char> letrasCorrectas { get; private set; } = new List<char>();
    public static string nuevaPalabra { get; private set; } = palabra;
  

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
    public static string devolverPalabra(char letra)
    {
        if (letra != '\0')
        {
            char[] caracteres = nuevaPalabra.ToCharArray();

            char letraCorrecta = buscarLetra(letra);

            for (int i = 0; i < nuevaPalabra.Length; i++)
            {
                if (palabra[i] == letraCorrecta)
                {
                    caracteres[i] = letra;
                    nuevaPalabra = new string(caracteres);
                }
            }
        }
        else
        {
            if(palabra == nuevaPalabra)
            {
                int i = 0;
                nuevaPalabra = palabra.Replace(palabra[i], '_');

                for (i = 0; i < palabra.Length; i++)
                {
                    nuevaPalabra = nuevaPalabra.Replace(palabra[i], '_');
                }
            }
            
        }

        return nuevaPalabra;
    }

    public static void agregarLetrasUsadas(char letra)
    {
        letrasUsadas.Add(letra);
    }

    private static char buscarLetra(char letra)
    {
        char LBuscada;
        int i = 0;

        while (i < palabra.Length && palabra[i] != letra)
        {
            i++;
        }
        if (i == palabra.Length)
        {
            LBuscada = '\0';
        }
        else
        {
            LBuscada = palabra[i];
        }
        return LBuscada;
    }

    public static bool buscarLetrasUsadas(char letra)
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