﻿
namespace Ejercicio1.Models;


//un cilindro es una figura? si
//una figura es un cilindro? no necesariamente
public class Cilindro : Figura
{
    public double Radio { get; set; }
  
    public Cilindro(double radio, double altura):base(altura)
    {
        this.Radio = radio;
    }

    public override double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio,2) * Altura;
    }

    public override string Describir()
    {
        return $"Cilindro: Radio={Radio:f2}, Altura={Altura:f2}, Vol.={CalcularVolumen():f2}";
    }
}
