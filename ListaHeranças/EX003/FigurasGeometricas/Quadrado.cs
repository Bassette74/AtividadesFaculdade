using System.Formats.Asn1;

namespace FigurasGeometricas;

public class Quadrado : Figuras
{   
    public double lado{ get;set;}

    protected override  void calcularArea(){
        double area;
        area =  lado * lado;
    }
    protected override void calcularPerimetro(){
        double perimetro;
        perimetro = 4 * lado;
    }

}
