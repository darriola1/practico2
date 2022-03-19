using System;

namespace Practico2
{
    class Program
    {
        static void Main(string[] args)
        {

            // EJERCICIO 1
            string marca = "Fiat";
            string modelo = "uno";
            bool exoneraImpuestos = true;
            int anio = 2010;
            string matricula = "jkt14215";


            Auto obj = new Auto
            {
                Marca = marca,
                Modelo = modelo,
                ExonerImpuestos = exoneraImpuestos,
                Anio = anio,
                Matricula = matricula
            };

            Console.WriteLine("Ejercicio 1 - ");
            Console.WriteLine();
            Console.WriteLine(obj.Marca);
            Console.WriteLine(obj.Modelo);
            Console.WriteLine(obj.Anio);
            Console.WriteLine(obj.Matricula);
            Console.WriteLine(obj.Marca);

            if (Auto.ValidarMatricula(matricula))
            {
                Console.WriteLine("la matricula es valida");
            }
            else
            {
                Console.WriteLine("la matricula NO es valida");
            }

            decimal patente = obj.CalcularPatente();
            Console.WriteLine(patente);
            Console.WriteLine();
            Console.WriteLine("Fin ejercicio 1"); 
            Console.WriteLine();

            //EJERCICIO2
            string nombre = "Denis";
            string apellido = "Arriola";
            DateTime fechaNacimiento = new DateTime(1991,06,22);
            decimal valorHora = 100;
            int antiguedad = 9;
            int horasTrabajadas = 200;

            Empleado unEmpleado = new Empleado
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fechaNacimiento,
                ValorHora = valorHora,
                Antiguedad = antiguedad,
                HorasTrabajadas = horasTrabajadas,

            };
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine();
            Console.WriteLine(unEmpleado);
            Console.WriteLine();
            Console.WriteLine("fin ejercicio 2");
        }

    }
}
