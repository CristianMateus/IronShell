using ChangePermission.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangePermission
{
    public partial class ChangePermission : Form
    {
        public ChangePermission()
        {
            InitializeComponent();
            
            //Se crea la intancia de la clase ProcessShell
            ProcessShell usuarios = new ProcessShell();
            
            // se cre objeto de tipo Proces, y se envia al metodo Start de la clase Process la ruta y el nombre del .bat
            Process proc = Process.Start(@"C:\\Users\\Camilo Gomez\\Desktop\\usuarios3.bat");

            //Codigo del bat para obtner usuarios: 
            // @echo off
            //Dir / b C: \Users > usuarios20.txt



            //Se invoca el metodo pintarUsuarios(); de la clase ProcessShell por medio del objeto "Usuarios"
            List<string> usu = usuarios.pintarUsuarios();

            //Se valida si lo que retorna el metodo "pintarUsuarios" sea diferente de nulo 
            if (usu != null)
            {
                //Si la condición se cumple entra en el foreach y asigna el valor de la lista al comboBox en cada iteración
                foreach (var item in usu)
                {
                    comboBox1.Items.Add(item);
                }

            }

            //Si el rtorno del metodo "pintarUsuarios" es nulo, retorna mensaje de excepción
            else
            {
                MessageBox.Show("Ocurrio un error cargando los usuarios");
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files (*.*)|*.*";
            open.Title = "Archivos";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }
            open.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
