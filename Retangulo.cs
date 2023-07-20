using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task04
{
    public class Retangulo{
        public double Largura;
        public double Altura;

        public double Area(){
            return Largura*Altura;
        }
        public double Perimetro(){
            return 2 * (Largura + Altura);
        }
        public double Diagonal(){
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}