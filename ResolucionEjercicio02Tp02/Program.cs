﻿using System;

namespace ResolucionEjercicio02Tp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Signos del Zodíaco y Horóscopo Chino";
            Console.Write("Ingrese su fecha de nacimiento:");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                if (fechaNacimiento <= DateTime.Today)
                {
                    string signoDelZodiaco = InformarSignoZodiaco(fechaNacimiento.Day, fechaNacimiento.Month);
                    Console.WriteLine($"Por haber nacido el día {fechaNacimiento.ToShortDateString()} le corresponde el signo de {signoDelZodiaco}");
                }
                else
                {
                    Console.WriteLine("Fecha mayor a la fecha actual");
                }
            }
            else
            {
                Console.WriteLine("Fecha mal ingresada");
            }
        }

        private static string InformarSignoZodiaco(int dia, int mes)
        {
            string signo;
            switch (mes)
            {
                case 1:
                    signo = dia >= 21 ? "Acuario" : "Capricornio";
                    break;
                case 2:
                    signo = dia >= 20 ? "Piscis" : "Acuario";
                    break;
                case 3:
                    signo = dia >= 21 ? "Aries" : "Piscis";
                    break;
                case 4:
                    signo = dia >= 21 ? "Tauro" : "Aries";
                    break;
                case 5:
                    signo = dia >= 21 ? "Géminis" : "Tauro";
                    break;
                case 6:
                    signo = dia >= 22 ? "Cáncer" : "Géminis";
                    break;
                case 7:
                    signo = dia >= 23 ? "Leo" : "Cáncer";
                    break;
                case 8:
                    signo = dia >= 24 ? "Virgo" : "Leo";
                    break;
                case 9:
                    signo = dia >= 23 ? "Libra" : "Virgo";
                    break;
                case 10:
                    signo = dia >= 23 ? "Escorpio" : "Libra";
                    break;
                case 11:
                    signo = dia >= 23 ? "Sagitario" : "Escorpio";
                    break;
                default:
                    signo = dia >= 21 ? "Capricornio" : "Sagitario";
                    break;
            }

            return signo;
        }
    }
}