using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ibtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ibtnIngresar_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();

            formulario.Show();                                      //Mostramos el formulario Inicio
            this.Hide();                                            //Ocultamos el formulario Login

            formulario.FormClosing += frm_Clossing;                 //Cuando se cierra el formulario de Inicio volvemos a mostrar el formulario de Login
        }
        private void frm_Clossing(object sender, FormClosingEventArgs e)
        {
            txtNumDoc.Text = "";
            txtContrasenia.Text = "";
            this.Show();
            //Con este evento logramos volver a mostrar el formulario Login luego de que cerramos el formulario Inicio
        }
    }
}
