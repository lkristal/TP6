using System;

namespace PrimerProyecto.Models
{
    public class Auto
    {
        public string Matricula {get; set;}
        public string Marca {get; set;}
        private int Velocidad {get;set;}
    }

    public class Patente
    {
        public string Matricula {get; set;}
        public DateTime FechaCompra {get; set;}
    }

}


