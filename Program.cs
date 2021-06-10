using System;
using System.IO;
using System.Globalization;

namespace P8_Diary_entry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea una nueva fecha, cuyo valor será el día de hoy.
            DateTime today = DateTime.Now;
            // Qué la fecha se acomode de acuerdo a la cultura de México.
            CultureInfo culture = new CultureInfo("es-MX");
            // Convertir la fecha a string, y guardarla en una string nueva.
            string todayAsStr = today.ToString(culture);
            // Separar la fecha de la hora con un "Split".
            string[] fechaYHoraHoy = todayAsStr.Split(" ");
            // Crear una string nueva con la string que está en la posición "0" del array, la cual es la fecha y no la hora.
            string fechaHoy = fechaYHoraHoy[0];
            // Se reemplaza el diagonal por un guión, debido a que el sistema interpreta a los diagonales cómo un directorio del sistema.
            string fechaParaDiario = fechaHoy.Replace("/", "-");

            // - Solicitar input al usuario con el texto a ingresar en la entrada del diario.
            Console.WriteLine("");
            Console.WriteLine("Introduzca su entrada para el diario:");
            string entradaDiario = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Su entrada del diario fue la siguiente:");
            Console.WriteLine(entradaDiario);

            // - El nombre del archivo deberá incluir la fecha del día en que se ejecuta el programa en su nombre.
            using (StreamWriter sw = new StreamWriter(fechaParaDiario + ".txt"))
            {
                // - Guardar el texto ingresado por el usuario en un archivo con extensión .txt
                sw.WriteLine(entradaDiario);
            }
        }
    }
}
