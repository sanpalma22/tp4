namespace Tp4.Models;

public class Indumentaria 
{
    public string Medias { get; private set; }
    public string Pantalon { get; private set; }
    public string Camiseta { get; private set; }

public Indumentaria (string med, string pant, string cam){
    Medias=med;
    Pantalon=pant;
    Camiseta=cam;
}

}
