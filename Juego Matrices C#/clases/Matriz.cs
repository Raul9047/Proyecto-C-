using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoProgram2.clases
{
    public class Matriz
    {
        public int[,] M { get; set; }

        public override string ToString()
        {
            string s = "";
            s += M[0, 0] + " ";
            s += M[0, 1] + " ";
            s += M[0, 2] + "\n";
            s += M[1, 0] + " ";
            s += M[1, 1] + " ";
            s += M[1, 2] + "\n";
            s += M[2, 0] + " ";
            s += M[2, 1] + " ";
            s += M[2, 2] + "";
            return s;
        }
    }
}
