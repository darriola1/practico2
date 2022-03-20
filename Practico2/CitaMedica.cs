using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    class CitaMedica
    {
        // atributos
        private int id;
        private DateTime fecha;
        private string cedula;
        private string lugar;
        private decimal precioBase;
        private bool urgente;

        // propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public decimal PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }
        public bool Urgente
        {
            get { return urgente; }
            set { urgente = value; }
        }

        // metodos

        public decimal CalcularCosto()
        {
            if (urgente)
            {
                return precioBase * 2;
            }
            return precioBase;
        }
    }
}
