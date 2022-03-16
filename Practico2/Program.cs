using System;

namespace Practico2
{
    class Program
    {
        static void Main(string[] args)
        {

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
        }

    }
}
