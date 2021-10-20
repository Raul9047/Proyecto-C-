using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoProgram2.clases
{
    public class Juego
    {
        public string Id { get; set; }
        public int Puntaje { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public Usuario usuario { get; set; }

        public override string ToString()
        {
            return usuario.Nombre + " nivel " + usuario.Nivel.NumeroNivel + " --> " + Puntaje + "ptos\n";
        }
    }
}
