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

            bool isAuthenticated = userRepository.AuthenticateUser(email, passwod);


            if (textEmail.Text =="" || textPass.Text=="")
            {
                MessageBox.Show("Enter the Email or Password");
            }
            else
            {
                if (isAuthenticated)
                {
                    LBLressult.Text = " you've been isAuthenticated";
                    LBLressult.Visible = true;
                    LBLressult.ForeColor = Color.Green;
                    /*if (LBLressult.ForeColor == Color.Green)
                    {
                        btnLogin.BackColor = Color.Green;
                    }*/
                    


                }
                else
                {
                    LBLressult.Text = "Wrong your Email or Password ";
                    LBLressult.Visible = true;
                    LBLressult.ForeColor = Color.Red;
                    /*if (LBLressult.ForeColor == Color.Red)
                    {
                        btnLogin.BackColor = Color.Red;
                    }*/
                    textEmail.Clear();
                    textPass.Clear();
                   

                }
            }

           
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLressult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
