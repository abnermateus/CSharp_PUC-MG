﻿using System;

namespace C_.Lista_POO
{
    public class Ex1
    {
        class Retangulo
        {
            double largura, altura;

            public void medidas(double largura, double altura)
            {
                this.largura = largura;
                this.altura = altura;
            }

            public double area()
            {
                return largura * altura;
            }

            public double perimetro()
            {
                return (largura + altura) * 2;
            }
        }

        /*
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.medidas(20.5, 15.5);
            Console.WriteLine("A área do retângulo é: " + retangulo.area());
            Console.WriteLine("O perímetro do retângulo é: " + retangulo.perimetro());
        }
        */
    }
}
