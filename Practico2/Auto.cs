using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    class Auto
    {
        private string marca = "";
        private string modelo = "";
        private bool exoneraImpuestos;
        private int anio = 0;
        private string matricula = "";

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        } 
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public bool ExonerImpuestos
        {
            get { return exoneraImpuestos; }
            set { exoneraImpuestos = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public static bool ValidarMatricula(string matricula)
        {
            return matricula.Length == 7;
        }

        public decimal CalcularPatente()
        {
            decimal patente = 0;
            if (anio >= 2015)
            {
                patente = 17000;
            }
            else
            {
                if (exoneraImpuestos)
                {
                    patente = 10000;
                }
                else {
                    patente = 12000;
                }
            }
            return patente;
        }
    }
}
