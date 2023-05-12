using Microsoft.AspNetCore.Mvc;
using Tp4.Models;
namespace Tp4.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria= Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria(){
        ViewBag.ListaEquipos=Equipos.ListaEquipos;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaCamisetas=Equipos.ListaCamisetas;
        return View();
    }
    public IActionResult GuardarIndumentaria (int Equipo, int Medias, int Shorts, int Camiseta){
        if(Equipo!=0&&Medias>0&&Shorts>0&&Camiseta>0){
            Indumentaria unaIndumentaria=new Indumentaria(Equipos.ListaMedias[Medias-1],Equipos.ListaPantalones[Shorts-1],Equipos.ListaCamisetas[Camiseta-1]);
        }
        //ViewBag.EquiposIndumentaria=Equipos.EquiposIndumentaria;
        return View("Index");
    }
}
