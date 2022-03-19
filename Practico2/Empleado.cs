using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    class Empleado
    {
        // atributos
        private string nombre = "";
        private string apellido = "";
        private DateTime fechaNacimiento ;
        private decimal valorHora = 0;
        private int antiguedad = 0;
        private int horasTrabajadas = 0;

        // propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public decimal ValorHora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }
        public int Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }
        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }

        // metodos
        public decimal CalcularSalario()
        {
            return valorHora * horasTrabajadas;
        }

        public int CalcularLicencia()
        {
            int licencia = 20;

            if (antiguedad <= 5)
            {
                licencia = 20;
            }
            else
            {
                if (antiguedad > 5 && antiguedad < 10)
                {
                    licencia = 21;
                }
                else
                {
                    licencia = 25;
                }
            }
            return licencia;
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Now;

            return ((hoy - fechaNacimiento).Days / 365);
        }

        public override string ToString()
        {
            return $"Empleado: {nombre} {apellido} \n" +
                $"- nacio en {fechaNacimiento.ToShortDateString()}, y tiene {CalcularEdad()} años \n" +
                $"- Tiene {CalcularLicencia()} dias de licencia \n" +
                $"- Su salario de este mes fueron {CalcularSalario()}";
        }
    }
}

