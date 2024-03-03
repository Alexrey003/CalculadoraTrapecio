namespace Application;

public class Trapecio
{
    /*variable -> ladosa = lados trapecio, variable -> basema = base mayor, variable -> baseme = base menor*/
    public static double Perimetro(double ladosa, double basema , double baseme)
    
    {
        double perimetro = (2*ladosa) + baseme + basema;
        return perimetro;
    }
    public static double Area(double basema, double baseme, double altura)
    {
        double area = (altura * (baseme + basema))/ 2;
        return area;
    }
}