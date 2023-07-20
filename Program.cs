using System;
using System.Globalization;
using task04;

namespace Task04{
    class Program{
        static void Main(String[] args){
            Retangulo r = new Retangulo();

            System.Console.WriteLine("Entre com as informações do retângulo: ");
            System.Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Área: "+r.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Perímetro: "+r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Diagonal: "+r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));     
        }
    }
}