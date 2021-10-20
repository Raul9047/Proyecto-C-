using ProyectoProgram2.clases;
using ProyectoProgram2.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoProgram2
{
    public partial class JuegoForm : Form
    {
        Usuario Usuario;
        Juego JuegoEnCurso;
        Pregunta Pregunta1;
        Pregunta Pregunta2;
        Pregunta Pregunta3;
        Pregunta Pregunta4;
        int preguntaActual;

        public JuegoForm(Usuario usuario)
        {
            InitializeComponent();
            JuegoEnCurso = new Juego();
            JuegoEnCurso.Puntaje = 0;
            JuegoEnCurso.usuario = usuario;
            label9.Text = "nivel " + usuario.Nivel.NumeroNivel;
            Usuario = usuario;
            Pregunta1 = new Pregunta();
            Pregunta1.Titulo = "Cuál de estas es la matriz triangular superior?";
            Pregunta1.Matrices = new List<Matriz>();
            Matriz m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;            //la pregunta 0 es la correcta
            m.M[0, 1] = 2;            //   {123}
            m.M[0, 2] = 3;            //   {012}
            m.M[1, 0] = 0;            //   {001}   triangular superior
            m.M[1, 1] = 1;
            m.M[1, 2] = 2;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta1.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 1;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 1;
            Pregunta1.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 0;
            Pregunta1.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 1;
            m.M[0, 2] = 0;
            m.M[1, 0] = 1;
            m.M[1, 1] = 1;
            m.M[1, 2] = 1;
            m.M[2, 0] = 0;
            m.M[2, 1] = 1;
            m.M[2, 2] = 0;
            Pregunta1.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta1.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 1;
            m.M[0, 2] = 2;
            m.M[1, 0] = 3;
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 0;
            Pregunta1.Matrices.Add(m);
            Pregunta1.Respuesta = 0;

            Pregunta2 = new Pregunta();
            Pregunta2.Titulo = "Cuál de estas es la matriz identidad?";
            Pregunta2.Matrices = new List<Matriz>();
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 9;                 // la pregunta 4 es la correcta 
            m.M[0, 1] = 9;                 //   {100}
            m.M[0, 2] = 9;                 //   {010}
            m.M[1, 0] = 9;                 //   {001}       matriz identidad
            m.M[1, 1] = 9;
            m.M[1, 2] = 9;
            m.M[2, 0] = 9;
            m.M[2, 1] = 9;
            m.M[2, 2] = 9;
            Pregunta2.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 2;
            m.M[0, 2] = 3;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 2;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta2.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 1;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 1;
            Pregunta2.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 0;
            Pregunta2.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta2.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 1;
            m.M[0, 2] = 2;
            m.M[1, 0] = 3;
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 0;
            Pregunta2.Matrices.Add(m);
            Pregunta2.Respuesta = 4;

            Pregunta3 = new Pregunta();
            Pregunta3.Titulo = "Cuál de estas es la matriz nula?";
            Pregunta3.Matrices = new List<Matriz>();
            Pregunta3.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;                       // la pregunta 0 es la correcta 
            m.M[0, 1] = 0;                       //     {000}
            m.M[0, 2] = 0;                       //     {000}
            m.M[1, 0] = 0;                       //     {000}  matriz nula 
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 0;
            Pregunta3.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 1;
            m.M[0, 2] = 2;
            m.M[1, 0] = 3;
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 0;
            Pregunta3.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta3.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 1;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 1;
            Pregunta3.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 2;
            m.M[0, 2] = 3;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 2;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta3.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 9;
            m.M[0, 1] = 9;
            m.M[0, 2] = 9;
            m.M[1, 0] = 9;
            m.M[1, 1] = 9;
            m.M[1, 2] = 9;
            m.M[2, 0] = 9;
            m.M[2, 1] = 9;
            m.M[2, 2] = 9;
            Pregunta3.Respuesta = 1;

            Pregunta4 = new Pregunta();
            Pregunta4.Titulo = "Cuál de estas es la matriz triangular inferior?";
            Pregunta4.Matrices = new List<Matriz>();
            Pregunta4.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;                  //la pregunta 3 es la correcta
            m.M[0, 1] = 1;                  //          {100}
            m.M[0, 2] = 0;                  //          {110}
            m.M[1, 0] = 1;                  //          {111}  triangular inferior
            m.M[1, 1] = 1;
            m.M[1, 2] = 1;
            m.M[2, 0] = 0;
            m.M[2, 1] = 1;
            m.M[2, 2] = 0;
            Pregunta4.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 9;
            m.M[0, 1] = 9;
            m.M[0, 2] = 9;
            m.M[1, 0] = 9;
            m.M[1, 1] = 9;
            m.M[1, 2] = 9;
            m.M[2, 0] = 9;
            m.M[2, 1] = 9;
            m.M[2, 2] = 9;
            Pregunta4.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 2;
            m.M[0, 2] = 3;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 2;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta4.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 1;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 1;
            m.M[2, 1] = 1;
            m.M[2, 2] = 1;
            Pregunta4.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 0;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 0;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 0;
            Pregunta4.Matrices.Add(m);
            m = new Matriz();
            m.M = new int[3, 3];
            m.M[0, 0] = 1;
            m.M[0, 1] = 0;
            m.M[0, 2] = 0;
            m.M[1, 0] = 0;
            m.M[1, 1] = 1;
            m.M[1, 2] = 0;
            m.M[2, 0] = 0;
            m.M[2, 1] = 0;
            m.M[2, 2] = 1;
            Pregunta4.Respuesta = 4;

            preguntaActual = 1;

            label1.Text = Pregunta1.Titulo;
            label2.Text = Pregunta1.Matrices[0].ToString();
            label3.Text = Pregunta1.Matrices[1].ToString();
            label4.Text = Pregunta1.Matrices[2].ToString();
            label5.Text = Pregunta1.Matrices[3].ToString();
            label6.Text = Pregunta1.Matrices[4].ToString();
            label7.Text = Pregunta1.Matrices[5].ToString();
            iniciarTiempo();
        }

        private void iniciarTiempo()
        {
            new Thread(new ThreadStart(temporizador)).Start();
        }

        public void temporizador()
        {
            int tiempo = JuegoEnCurso.usuario.Nivel.NumeroNivel * 5;
            int preguntaEsperando = preguntaActual;
            while (tiempo > 0)
            {
                if (label8.InvokeRequired)
                {
                    label8.Invoke(new MethodInvoker(
                        delegate
                        {
                            if (preguntaEsperando == preguntaActual)
                            {
                                label8.Text = tiempo + " seg.";
                            }
                        }));
                }
                tiempo--;
                Thread.Sleep(1000);
            }
            Invoke(new MethodInvoker(
                delegate
                {
                    if (preguntaEsperando == preguntaActual)
                    {
                        siguientePregunta();
                    }
                }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siguientePregunta();
        }

        private void siguientePregunta()
        {
            if (radioButton1.Checked)
            {
                verificar(0);
            }
            if (radioButton2.Checked)
            {
                verificar(1);
            }
            if (radioButton3.Checked)
            {
                verificar(2);
            }
            if (radioButton4.Checked)
            {
                verificar(3);
            }
            if (radioButton5.Checked)
            {
                verificar(4);
            }
            if (radioButton6.Checked)
            {
                verificar(5);
            }
            preguntaActual++;
            if (preguntaActual == 2)
            {
                label1.Text = Pregunta2.Titulo;
                label2.Text = Pregunta2.Matrices[0].ToString();
                label3.Text = Pregunta2.Matrices[1].ToString();
                label4.Text = Pregunta2.Matrices[2].ToString();
                label5.Text = Pregunta2.Matrices[3].ToString();
                label6.Text = Pregunta2.Matrices[4].ToString();
                label7.Text = Pregunta2.Matrices[5].ToString();
            }
            if (preguntaActual == 3)
            {
                label1.Text = Pregunta3.Titulo;
                label2.Text = Pregunta3.Matrices[0].ToString();
                label3.Text = Pregunta3.Matrices[1].ToString();
                label4.Text = Pregunta3.Matrices[2].ToString();
                label5.Text = Pregunta3.Matrices[3].ToString();
                label6.Text = Pregunta3.Matrices[4].ToString();
                label7.Text = Pregunta3.Matrices[5].ToString();
            }
            if (preguntaActual == 4)
            {
                label1.Text = Pregunta4.Titulo;
                label2.Text = Pregunta4.Matrices[0].ToString();
                label3.Text = Pregunta4.Matrices[1].ToString();
                label4.Text = Pregunta4.Matrices[2].ToString();
                label5.Text = Pregunta4.Matrices[3].ToString();
                label6.Text = Pregunta4.Matrices[4].ToString();
                label7.Text = Pregunta4.Matrices[5].ToString();
                button1.Text = "Finalizar";
            }
            if (preguntaActual == 5)
            {
                new FinForm(JuegoEnCurso).Show();
                Hide();
                return;
            }
            iniciarTiempo();
        }

        private void verificar(int respuesta)
        {
            if (preguntaActual == 1)
            {
                if (Pregunta1.Respuesta == respuesta)
                {
                    JuegoEnCurso.Puntaje += 25;
                }
            }
            if (preguntaActual == 2)
            {
                if (Pregunta2.Respuesta == respuesta)
                {
                    JuegoEnCurso.Puntaje += 25;
                }
            }
            if (preguntaActual == 3)
            {
                if (Pregunta3.Respuesta == respuesta)
                {
                    JuegoEnCurso.Puntaje += 25;
                }
            }
            if (preguntaActual == 4)
            {
                if (Pregunta4.Respuesta == respuesta)
                {
                    JuegoEnCurso.Puntaje += 25;
                }
            }
        }

        private void JuegoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
