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

namespace ProyectoProgram2
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = textBox1.Text;
            usuario.Ci = Convert.ToInt32(textBox2.Text);
            usuario.usuario = textBox3.Text;
            usuario.Contraseña = textBox4.Text;
            Nivel nivel = new Nivel();
            nivel.NumeroNivel = 3;
            usuario.Nivel = nivel;
            string json = "[]";
            if (File.Exists(Application.StartupPath + "/usuarios.txt"))
            {
                json = File.ReadAllText(Application.StartupPath + "/usuarios.txt");
            }
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            usuarios.Add(usuario);
            File.WriteAllText(Application.StartupPath + "/usuarios.txt", JsonConvert.SerializeObject(usuarios));
            MessageBox.Show("Felicidades, has sido registrado correctamente, por favor inicia sesion");
            new Form1().Show();
            Hide();
        }
    }
}
