using System.Net.Security;

namespace FigurasGeometricas;

public class Circulo : Figuras
{

    public double raio{get;set;}

    protected override void calcularArea()
    {
        double area;
       area = Math.PI * Math.Pow(raio, 2);
    }
    protected override void calcularPerimetro()
    {
        double perimetro;
        perimetro = Math.PI * raio * raio ;
    }
}
