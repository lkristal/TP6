using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.ComponentModel;
using System.IO.Compression;
using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP6.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace TP6.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment Environment;


        public HomeController(IWebHostEnvironment _environment)
        {	
            Environment = _environment;
        }

        public IActionResult Index()
        {
            ViewBag.Equipos = BD.ListarEquipos();
            return View();
        }

        public IActionResult VerDetalleEquipo(int IdEquipo)
        {
            ViewBag.Equipo = BD.VerInfoEquipo(IdEquipo);
            ViewBag.Jugadores = BD.ListarJugadores(IdEquipo);
            return View();
        }

        public IActionResult VerDetalleJugador(int IdJugador)
        {
            ViewBag.Jugador = BD.VerInfoJugador(IdJugador);
            return View();
        }
        
        public Jugador VerDetalleJugadorAjax(int IdJugador)
        {
            ViewBag.Jugador = BD.VerInfoJugador(IdJugador);
            return ViewBag.Jugador;
        }

        public IActionResult AgregarJugador(int IdEquipo)
        {
            ViewBag.IdEquipo = IdEquipo;
            return View();
        }

        [HttpPost]
        public IActionResult GuardarJugador(Jugador Jug, IFormFile ArchivoFoto)
        {

            if (ArchivoFoto.Length>0)
            {
                string wwwRootLocal = this.Environment.ContentRootPath + @"\wwwroot\" + ArchivoFoto.FileName;
                using (var stream = System.IO.File.Create(wwwRootLocal))
                {
                    ArchivoFoto.CopyToAsync(stream);
                }
                Jug.Foto = ArchivoFoto.FileName;
            }
            BD.AgregarJugador(Jug);

           return RedirectToAction("VerDetalleEquipo","Home", new{IdEquipo = Jug.IdEquipo});
        }

        public IActionResult EliminarJugador(int IdJugador, int IdEquipo)
        {
            BD.EliminarJugador(IdJugador);
            ViewBag.Equipo = BD.VerInfoEquipo(IdEquipo);
            ViewBag.Jugadores = BD.ListarJugadores(IdEquipo);
            return View("VerDetalleEquipo");
        }

    }
}
