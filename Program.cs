﻿using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {

       string dia = " ";
            Console.WriteLine("Dias da semana");


            int x = int.Parse(Console.ReadLine());
            switch (x) {

                case 1:
                    dia = "Domingo";
                    break;       
                case 2:
                dia = "Segunda";
                break;

                case 3:
                dia = "Terça"    ;
                break;
                
                 default:
                dia = " Valor inválido";
                break;
            }
            System.Console.WriteLine("Dia da semana " + dia);

            System.Console.WriteLine("TESTE 1");
            System.Console.WriteLine("Teste 2");


            Carros fusca = new Carros();

            fusca.Nome = Console.ReadLine();

            System.Console.WriteLine(fusca.Nome);
             System.Console.WriteLine(fusca.Nome);
             System.Console.WriteLine("ola");

        }
    }
}