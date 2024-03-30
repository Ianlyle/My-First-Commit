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
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataReader reader;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\2ND SEM\APPSDEV\FinalProject\Login.accdb""");

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM [User] WHERE Username = '" + TxtUser.Text + "' AND Password = '" + TxtPassword.Text + "'";
            cmd = new OleDbCommand(q, con);

            con.Open();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Success");
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID, Please enter username and password");
            }

            reader.Close();
            con.Close();
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked == false) 
            { 
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.Show();
            this.Hide(); 
        }
    }
}
