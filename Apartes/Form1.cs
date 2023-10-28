using Apartes.Repositorry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();

            string email = textEmail.Text;
            string passwod = textPass.Text;

            bool isAuthenticatd = userRepository.AuthenticateUser(email, passwod);

            if (isAuthenticatd)
            {
                LBLressult.Text = " you've been isAuthenticated";
                LBLressult.Visible = true;
                LBLressult.ForeColor = Color.Green;
            }
            else
            {
                LBLressult.Text = " your Email or Password is incorrect";
                LBLressult.Visible = true;
                LBLressult.ForeColor = Color.Red;
            }
        }
    }
}
