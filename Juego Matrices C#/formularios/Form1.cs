using Newtonsoft.Json;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = tbCorreo.Text;
            string contraseña = tbContraseña.Text;
            Usuario usuario = new Usuario();
            usuario.usuario = correo;
            usuario.Contraseña = contraseña;
            string json = "[]";
            if (File.Exists(Application.StartupPath + "/usuarios.txt"))
            {
                json = File.ReadAllText(Application.StartupPath + "/usuarios.txt");
            }
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            foreach (Usuario usuarioGuardado in usuarios)
            {
                if (usuario.usuario.Equals(usuarioGuardado.usuario))
                {
                    if (usuario.Contraseña.Equals(usuarioGuardado.Contraseña))
                    {
                        MessageBox.Show("Bienvenido al juego de matrices\nEl juego consiste en reconocer en el menor tiempo posible las diferentes matrices que se te mostraran por pantalla, si aciertas en el menor tiempo, subirás de nivel.\n Suerte!");
                        new JuegoForm(usuarioGuardado).Show();
                        Hide();
                        return;
                    }
                    MessageBox.Show("Contraseña incorrecta");
                    return;
                }
            }
            MessageBox.Show("Usuario no existe.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Registro().Show();
            Hide();
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
