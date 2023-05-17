namespace Tp4.Models;

public class Indumentaria 
{
    public string Medias { get; private set; }
    public string Shorts { get; private set; }
    public string Camiseta { get; private set; }

public Indumentaria (string med, string shor, string cam){
    Medias=med;
    Shorts=shor;
    Camiseta=cam;
}

}
