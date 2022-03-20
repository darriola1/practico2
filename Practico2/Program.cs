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
            string matricula = "jkt1415";


            Auto obj = new Auto
            {
                Marca = marca,
                Modelo = modelo,
                ExonerImpuestos = exoneraImpuestos,
                Anio = anio,
                Matricula = matricula
            };

            Console.WriteLine("EJERCICIO 1");
            Console.WriteLine();
            Console.WriteLine($"MARCA: {obj.Marca}");
            Console.WriteLine($"MODELO: {obj.Modelo}");
            Console.WriteLine($"AÑO: {obj.Anio}");
            Console.WriteLine($"MATRICULA: {obj.Matricula}");
            

            if (Auto.ValidarMatricula(matricula))
            {
                Console.WriteLine("la matricula es valida");
            }
            else
            {
                Console.WriteLine("la matricula NO es valida");
            }

            decimal patente = obj.CalcularPatente();
            Console.WriteLine($"PATENTE: {patente}");
            Console.WriteLine();
            Console.WriteLine("FIN EJERCICIO 1");
            Console.WriteLine();

            //EJERCICIO2
            string nombre = "Denis";
            string apellido = "Arriola";
            DateTime fechaNacimiento = new DateTime(1991, 06, 22);
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
            Console.WriteLine("EJERCICIO 2");
            Console.WriteLine();
            Console.WriteLine(unEmpleado);
            Console.WriteLine();
            Console.WriteLine("FIN EJERCICIO 2");
            Console.WriteLine();

            // EJERCICIO 3
            Console.WriteLine("EJERCICIO 3");
            int id = 1;
            DateTime fecha = new DateTime(2021, 03, 19);
            string cedula = "44042498";
            string lugar = "Montevideo";
            decimal precioBase = 10;
            bool urgente = true;

            CitaMedica nuevaCita = new CitaMedica
            {
                Id = id,
                Fecha = fecha,
                Cedula = cedula,
                Lugar = lugar,
                PrecioBase = precioBase,
                Urgente = urgente,
            };

            Console.WriteLine();
            Console.WriteLine($"Id de la cita {nuevaCita.Id}");
            Console.WriteLine($"La fecha de la cita es: {nuevaCita.Fecha}");
            Console.WriteLine($"Documento: {nuevaCita.Cedula}");
            Console.WriteLine($"En la sucursal de: {nuevaCita.Lugar}");
            Console.WriteLine($"El usuario debe abonar: {nuevaCita.CalcularCosto()} pesos");
            Console.WriteLine();
            Console.WriteLine("FIN EJERCICIO 3");
        }

    }
}
