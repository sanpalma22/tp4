using System.Collections.Generic;
namespace Tp4.Models;

public static class Equipos
{
    public static List<string> ListaEquipos { get; private set; } = new List<string>(){ "Boca", "River", "San Lorenzo", " Independiente", "Racing", "Banfield", "Rosario Central", "Talleres", "Lanus", "Belgrano" };
    public static List<string> ListaMedias { get; private set; } = new List<string>(){ "mediasBoca.webp", "mediasRiver.jpg", "mediasSanLorenzo.jpg", "mediasIndependiente.jpg", "mediasRacing.webp", "mediasBanfield.webp", "mediasRosarioCentral.jpg", "mediasTalleres.jpg", "mediasLanus.jpg", "mediasBelgrano.jpg" };
    public static List<string> ListaPantalones { get; private set; } = new List<string>(){ "shortBoca.jfif", "shortRiver.jpg", "shortSanLorenzo.jfif", "shortIndependiente.jfif", "shortRacing.jpg", "shortBanfield.jfif", "shortRosarioCentral.jpg", "shortTalleres.webp", "shortLanus.jfif", "shortBelgrano.jpg" };
    public static List<string> ListaCamisetas { get; private set; } = new List<string>(){ "remeraBoca.jfif", "remeraRiver.webp", "remeraSanLorenzo.jfif", "remeraIndependiente.webp", "remeraRacing.webp", "remeraBanfield.webp", "remeraRosarioCentral.jpg", "remeraTalleres.jpg", "remeraLanus.jpg", "remeraBelgrano.jpg" };
    public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }
    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
    {
        bool equipoExistente=false;
        
        return equipoExistente;
    }
}

