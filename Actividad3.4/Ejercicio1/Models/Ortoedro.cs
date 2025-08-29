
namespace Ejercicio1.Models;

public class Ortoedro : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }
    public double Largo { get; set; }

    public Ortoedro(double ancho, double alto, double largo):base(alto)
    {
        this.Ancho = ancho;
        Largo = largo;
    }

    override public double CalcularVolumen()
    {
        return Ancho*Alto*Largo;
    }

    public override string Describir()
    {
        return $"Ortoedro: An: {Ancho:f2}, Al: {Alto:f2}, La: {Largo:f2}, Vol:{CalcularVolumen():f2}"; 
    }
}
