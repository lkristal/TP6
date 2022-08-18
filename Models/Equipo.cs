using System;

namespace TP6.Models
{
    public class Equipo
    {
        private int _IdEquipo;
        private string _Nombre;
        private string _Escudo;
        private string _Camiseta;
        private string _Continente;
        private int _CopasGanadas;
        
        public Equipo() {
        }
        
        public Equipo(int pIdEquipo, string pNombre, string pEscudo, string pCamiseta, string pContinente,int pCopasGanadas)
        {
            _IdEquipo = pIdEquipo; _CopasGanadas = pCopasGanadas;
            _Camiseta = pCamiseta; _Escudo = pEscudo; _Nombre = pNombre; _Continente = pContinente;
        }
        
        public int IdEquipo { get { return _IdEquipo;} set { _IdEquipo = value;}}
        public string Nombre { get {return _Nombre;} set { _Nombre = value;}}
        public string Escudo { get {return _Escudo;} set { _Escudo = value;}}
        public string Camiseta { get {return _Camiseta;} set { _Camiseta = value;}}
        public string Continente { get {return _Continente;} set { _Continente = value;}}
        public int CopasGanadas { get { return _CopasGanadas;} set { _CopasGanadas = value;}}
        
    }
}
