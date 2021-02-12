using System;

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

            

        }
    }
}