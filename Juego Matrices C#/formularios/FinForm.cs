using Newtonsoft.Json;
using ProyectoProgram2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgram2.formularios
{
    public partial class FinForm : Form
    {
        Juego j;
        public FinForm(Juego juego)
        {
            InitializeComponent();
            j = juego;
            string json = "[]";
            if (File.Exists(Application.StartupPath + "/juegos.txt"))
            {
                json = File.ReadAllText(Application.StartupPath + "/juegos.txt");
            }
            List<Juego> juegos = JsonConvert.DeserializeObject<List<Juego>>(json);
            juegos.Add(juego);
            File.WriteAllText(Application.StartupPath + "/juegos.txt", JsonConvert.SerializeObject(juegos));
            string s = "Juego terminado\nTu puntaje es: " + juego.Puntaje + "\n\n";
            for (int i = juegos.Count - 1, c = 1; i >= 0 && c <= 10; i--, c++)
            {
                s += juegos[i].ToString();
            }
            label1.Text = s;
        }

        private void FinForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new JuegoForm(j.usuario).Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}
