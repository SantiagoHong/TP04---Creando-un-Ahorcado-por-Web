using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Ahorcado.Models;

namespace TP04_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult JugarLetra(char? letra)
    {
        if (letra == null)
        {
            ViewBag.Palabra = Juego.devolverPalabra(letra);
            ViewBag.letrasUsadas = Juego.letrasUsadas;
            ViewBag.Respuesta = Juego.palabra;
            ViewBag.Intentos = Juego.intentos;

            return View("juego");
        }
        else
        {
            if (!Juego.buscarLetrasUsadas(letra))
            {
                ViewBag.Palabra = Juego.devolverPalabra(letra);
                Juego.agregarLetrasUsadas(letra);
                ViewBag.letrasUsadas = Juego.letrasUsadas;
                ViewBag.Respuesta = Juego.palabra;
                ViewBag.Intentos = Juego.intentos;

                if (ViewBag.Palabra == Juego.palabra)
                {
                    ViewBag.Mensaje = "GANASTE";
                    return View("Resultado");
                }
                else
                {
                    Juego.intentos++;
                    ViewBag.Intentos = Juego.intentos;
                    return View("juego");
                }
            }
            else
            {
                ViewBag.Mensaje = "YA PUSISTE ESTA LETRA";
                ViewBag.Palabra = Juego.devolverPalabra(letra);
                ViewBag.letrasUsadas = Juego.letrasUsadas;
                ViewBag.Respuesta = Juego.palabra;
                ViewBag.Intentos = Juego.intentos;

                return View("juego");
            }
        }

    }
    public IActionResult JugarPalabra(string palabra)
    {
        ViewBag.Palabra = Juego.palabra;
        ViewBag.Intentos = Juego.intentos;
        if (Juego.DevolverPalabraComp(palabra) == 1)
        {
            ViewBag.Mensaje = "GANASTE";
            ViewBag.letrasUsadas = Juego.letrasUsadas;
            ViewBag.Respuesta = Juego.palabra;
            ViewBag.Intentos = Juego.intentos;
        }
        else
        {
            ViewBag.Mensaje = "PERDISTE";
            ViewBag.letrasUsadas = Juego.letrasUsadas;
            ViewBag.Respuesta = Juego.palabra;
            ViewBag.Intentos = Juego.intentos;
        }

        return View("Resultado");
    }

}
