using System;

namespace TP6.Models
{
    public class Jugador
    {
        private int _IdEquipo;
        private int _IdJugador;
        private string _Nombre;
        private DateTime _FechaNacimiento;
        private string _Foto;
        private string _EquipoActual;

        public Jugador(){}
        
        public Jugador(int pIdEquipo, int pIdJugador, string pNombre, DateTime pFechaNacimiento, string pFoto, string pEquipoActual)
        {
            _IdEquipo = pIdEquipo; _IdJugador = pIdEquipo;
            _Foto = pFoto; _EquipoActual = pEquipoActual; _Nombre = pNombre;
            _FechaNacimiento = pFechaNacimiento;
        }
        
        public int IdEquipo { get { return _IdEquipo;} set { _IdEquipo = value;}}
        public int IdJugador { get { return _IdJugador;} set { _IdJugador = value;}}
        public string Nombre { get {return _Nombre;} set { _Nombre = value;}}
        public string Foto { get {return _Foto;} set { _Foto = value;}}
        public string EquipoActual { get {return _EquipoActual;} set { _EquipoActual = value;}}
        public DateTime FechaNacimiento { get {return _FechaNacimiento;} set { _FechaNacimiento = value;}}

        
    }
}
