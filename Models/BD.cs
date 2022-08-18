using System.Security.AccessControl;
using System.Data;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace TP6.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=LEOK\SQLEXPRESS; DataBase=Qatar2022;Trusted_Connection=True;";
        
        public static void AgregarJugador(Jugador Jug)
        {
            string SQL = "INSERT INTO Jugadores(IdEquipo, Nombre, FechaNacimiento) VALUES (@pIdEquipo, @pNombre, @pFechaNacimiento)";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {pNombre = Jug.Nombre, pIdEquipo = Jug.IdEquipo, pFechaNacimiento = Jug.FechaNacimiento});
            }
        } 

        public static int EliminarJugador(int IdJugador)
        {
            int Result = 0;
            string SQL = "DELETE FROM Jugadores WHERE IdJugador=@pIdJugador";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Result = db.Execute(SQL, new {pIdJugador = IdJugador});
            }
            return Result;
        } 

        public static Equipo VerInfoEquipo(int IdEquipo)
        {
            Equipo MiEquipo = null;
            string SQL = "SELECT * FROM Equipos WHERE IdEquipo = @pIdEquipo";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                MiEquipo = db.QueryFirstOrDefault<Equipo>(SQL, new {pIdEquipo = IdEquipo});
            }
            return MiEquipo;
        }

        public static Jugador VerInfoJugador(int IdJugador)
        {
            Jugador MiJugador = null;
            string SQL = "SELECT * FROM Jugadores WHERE IdJugador = @pIdJugador";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                MiJugador = db.QueryFirstOrDefault<Jugador>(SQL, new {pIdJugador = IdJugador});
            }
            return MiJugador;
        }

        public static List<Equipo> ListarEquipos()
        {
            List<Equipo> ListaEquipos = null;
            string SQL = "SELECT * FROM Equipos";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                ListaEquipos = db.Query<Equipo>(SQL).ToList();
            }
            return ListaEquipos;
        }

        public static List<Jugador> ListarJugadores(int IdEquipo)
        {
            List<Jugador> ListaJugadores = null;
            string SQL = "SELECT * FROM Jugadores WHERE IdEquipo=@pIdEquipo";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                ListaJugadores = db.Query<Jugador>(SQL, new {pIdEquipo = IdEquipo}).ToList();
            }
            return ListaJugadores;
        }


    }
}
