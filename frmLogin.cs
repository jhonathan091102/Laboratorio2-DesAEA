using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PrincipalMDI principal = new PrincipalMDI();
            //principal.Show();
            //this.Hide();

            String[] user = { "PercyJ98", "PauloA65", "IvanO41", "HaroldA69"};
            String[] pass = { "tecsupP98", "tecsupP65", "tecsupI41", "tecsupH69"};


            if (user.Contains(txtUsuario.Text) && pass.Contains(txtPassword.Text) 
                && Array.IndexOf(user, txtUsuario.Text) == Array.IndexOf(pass, txtPassword.Text))
            {
                principal.Show();
                this.Hide();
            }
            else
            {
                msgError.Visible = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
