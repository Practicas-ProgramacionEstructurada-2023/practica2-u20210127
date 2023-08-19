using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables de texto capturando desde la terminal
            string? nombre;
            string? apellido;

            //Declaracion de variables de texto desde codigo
            string? codigo_estudiantil = "u20210127";
            string? becado = "Si";

            //Declarion de variables de tipo enteras capturando desde la terminal
            int edad;

            //Declarion de varibales de tipo enteras desde codigo
            int AñoIngreso = 2021;
            int AñoEgreso = 2026;

            //Declarion de variables decimales capturando desde la terminal
            double mensualidad;

            //Declarion de variables decimales desde codigo
            double transporte = 2.50;
            double alimenacion = 3.75;

            //Declarion de variable de tiempo o time
            DateTime FechaActual = DateTime.Now;
            DateTime FechaEspecifica = new DateTime(23, 8, 19, 16, 20, 00);


            //Obtencion de datos desde la terminal
            Console.WriteLine("Ingrese su nombre:");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su apellido:");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese su mensualidad universitaria:");
            mensualidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Impresion de datos
            Console.WriteLine("******************Inicion de impresion******************");
            Console.WriteLine("Su nombre: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su codigo estudiantil es: " + codigo_estudiantil);
            Console.WriteLine("Es becado? " + becado);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su año de ingreso fue: " + AñoIngreso);
            Console.WriteLine("Su año de egreso sera: " + AñoEgreso);
            Console.WriteLine("Su mensualidad universitaria es: " + "$" + mensualidad);
            Console.WriteLine("Su gasto diario de transporte es: " + "$" + transporte);
            Console.WriteLine("Su gasto diario de alimentacion es: " + "$" + alimenacion);
            Console.WriteLine("La fecha y tiempo de impresion de datos es: " + FechaActual);
            Console.WriteLine("La fecha que termina la pratica es: " + FechaEspecifica);
            Console.WriteLine("******************Fin de impresion******************");


            Console.WriteLine("******************Inicion de impresion******************");
            //APLICACION DE FUNCIONES DE CADENA

            //Funcion de comparacion cadenas de texto
            bool cadenaComparativa= nombre == apellido;

            //Funcion de Minuscula
            string? funcionMinuscula1 = nombre.ToLower();
            string? funcionMinuscula2 = apellido.ToLower();

            //Funcion de Mayuscula
            string? funcionMayuscula1 = nombre.ToUpper();
            string? funcionMayuscula2 = apellido.ToUpper();

            //Funcion de Concatenado
            string? cadenaConcatenada = nombre + " " + apellido;

            //Funcion de tamaño de cadena
            int llongitudCadena1=nombre.Length;
            int llongitudCadena2=apellido.Length;

            Console.WriteLine("Comparacion: " + cadenaComparativa);
            Console.WriteLine("Mayuscula Nombre y Apellido: " + funcionMayuscula1 + " " + funcionMayuscula2);
            Console.WriteLine("Minuscula Nombre y Apellido: " + funcionMinuscula1 + " " + funcionMinuscula2);
            Console.WriteLine("Concatenacion: " + cadenaConcatenada);
            Console.WriteLine("La longitud de datos de nombre es: " + llongitudCadena1);
            Console.WriteLine("La longitud de datos de apellido e: " + llongitudCadena2);
            Console.WriteLine("******************Fin de impresion******************");
        }
    }
}