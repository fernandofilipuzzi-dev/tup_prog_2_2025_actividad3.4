
namespace Ejercicio1.Models;

abstract public class Figura :IComparable
{
    public double Altura { get; set; }

    public Figura(double altura)
    { 
        Altura = altura;
    }

    abstract public string Describir();
    
    virtual public double CalcularVolumen()
    {
        return 0;
    }

    public override string ToString()
    {
        return Describir(); //comportamiento polimorfico!
    }

    public int CompareTo(object otra)
    {
        Figura otraFigura=otra as Figura;
        if (otraFigura != null)
        {
            return CalcularVolumen().CompareTo(otraFigura.CalcularVolumen());
        }
        return -1;
    }
}
