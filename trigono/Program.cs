using System;

namespace trigono
{
    class Program
    {
        static void Main(string[] args)
        {    
            string opcao = "";

            Console.WriteLine("Calcula area");
            Console.WriteLine("1 - Quadrado")
            Console.WriteLine("2 - Triângulo")
            Console.WriteLine("3 - Losango")
            Console.WriteLine("4 - Circulo")
            Console.WriteLine("5 - Trapézio")
            Console.WriteLine("6 - Retângulo")
            opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                Console.WriteLine("Área do Triângulo");
                Console.Write("Entre com a Base: ");
                double baseTri = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura: ");
                double altTri = double.Parse(Console.ReadLine());
                double = (baseTri * altTri) / 2;
                Console.WriteLine("A área do triângulo é: " + areaTri);
                break;
            
            case "2":
                Console.WriteLine("Área do Quadrado");
                Console.Write("Entre com a Base: ");
                double baseQuad = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura: ");
                double altQuad = double.Parse(Console.ReadLine());
                double = (baseQuad * altQuad) / 2;
                Console.WriteLine("A área do Quadrado é: " + areaQuad);
                break;

            case "3":
                Console.WriteLine("Área do Losango");
                Console.Write("Entre com a Base: ");
                double baseLos = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura: ");
                double altLos = double.Parse(Console.ReadLine());
                double = (baseLos * altLos) / 2;
                Console.WriteLine("A área do Losango é: " + areaLos);
                break;

            case "4":
                Console.WriteLine("Área do Circulo");
                Console.Write("Entre com a Base: ");
                double baseCir = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura: ");
                double altCir = double.Parse(Console.ReadLine());
                double = (baseCir * altCir) / 2;
                Console.WriteLine("A área do Circulo é: " + areaCir);
                break;

            case "5":
                Console.WriteLine("Área do Trapézio");
                Console.Write("Entre com a Base: ");
                double baseTrap = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura: ");
                double altTrap = double.Parse(Console.ReadLine());
                double = (baseTrap * altTrap) / 2;
                Console.WriteLine("A área do Trapézio é: " + areaTrap);
                break;

            case "6":
                Console.WriteLine("Área do Retângulo");
                Console.Write("Entre com a Base: ");
                double baseRet = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura: ");
                double altRet = double.Parse(Console.ReadLine());
                double = (baseRet * altRet) / 2;
                Console.WriteLine("A área do Retângulo é: " + areaRet);
                break;
            }
        }
    }
}
