using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\2ND SEM\\APPSDEV\\FinalProject\\Login.accdb\"");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
          if ( TxtUser.Text == "" && TxtPassword.Text == "" && TxtConfirm.Text == "")
            {
                MessageBox.Show("Username and Password are empty", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (TxtPassword.Text == TxtConfirm.Text)
            {
                con.Open();
                string register = "INSERT INTO [User] VALUES ( '" + TxtUser.Text + "','" + TxtPassword.Text + "')";
                cmd = new OleDbCommand(register,con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          else
            {
                MessageBox.Show("Password does not match, PLease Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Text = "";
                TxtConfirm.Text = "";
                TxtPassword.Focus();
            }
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked == false)
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtConfirm.UseSystemPasswordChar = false;
            }
            else 
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtConfirm.UseSystemPasswordChar = true;
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
