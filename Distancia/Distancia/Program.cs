﻿using System;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {

            int distancia, tempo;

            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");

        }
    }
}
