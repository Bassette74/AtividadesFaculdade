namespace FigurasGeometricas;

public class Triangulo : Figuras
{
    public double lado1 , lado2 , lado3;

    protected override void calcularArea()
    {
        double s = (lado1 + lado2 + lado3) /2 ;
        double area;
        area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

    }

    protected override void calcularPerimetro()
    {
        double perimetro;
        perimetro = (lado1 + lado2 + lado3);
    }

}
