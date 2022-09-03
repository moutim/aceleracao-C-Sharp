namespace identifyTriangle;

public class Triangle
{
  public static string IdentifyTriangle(double xSide, double ySide, double zSide)
  {       
      var name = "";


      if(xSide == ySide && xSide == zSide)
      {
          name = "Triângulo Equilátero";
      }
      else if((xSide == ySide) || (xSide == zSide) || (ySide ==zSide))
      {
          name = "Triângulo Isóscele";
      }
      else
      {
          name = "Triângulo Escaleno";
      }
      return name;
  }
}

public class Polygon
{
  public static string IdentifyPolygon(int sideCount)
  {
      var name = string.Empty;
      switch (sideCount)
      {
          case < 3:
              name = "Não é um polígono";
              break;
          case 3:
              name = "Triângulo";
              break;
          case 4:
              name = "Quadrado";
              break;
          case 5:
              name = "Pentágono";
              break;
          default:
              name = "Polígono não identificado";
              break;
      }
      return name;
  }
}


