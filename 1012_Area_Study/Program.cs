using System;
using System.Globalization;
using System.Net.NetworkInformation;

class URI {
    static void Main(string[] args) {

        //Os valores de entrada são lidos como uma única linha e divididos em três partes (A, B e C), usando .Split(' ');, cada uma representando um dos valores solicitados. 

        string[] lados = Console.ReadLine().Split(' ');

        double A, B, C, pi;

        A = double.Parse(lados[0], CultureInfo.InvariantCulture);
        B = double.Parse(lados[1], CultureInfo.InvariantCulture); 
        C = double.Parse(lados[2], CultureInfo.InvariantCulture);
        pi = 3.14159;

        //base x altura/2
        double Areatriangulo = A * C/2;

        //area = pi x Raio ao cubo
        double AreaCirculo = pi * Math.Pow(C, 2.0);

        //A = (a+b) h /2
        double AreaTrapezio = (A + B) * C /2;

        // lado ao quadrado
        double AreaQuadrado = Math.Pow(B, 2.0); 

        //A = b⋅h.
        double AreaRetangulo = A * B;


        Console.WriteLine("TRIANGULO: " + Areatriangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + AreaCirculo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + AreaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + AreaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        

        Console.ReadLine();

    }

}