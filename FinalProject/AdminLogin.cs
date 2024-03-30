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
    public partial class AdminLogin : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataReader reader;
        public AdminLogin()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\2ND SEM\APPSDEV\FinalProject\AdminLogin.accdb""");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM [admin] WHERE Admin = '" + TxtUser.Text + "' AND Password = '" + TxtPassword.Text + "'";
            cmd = new OleDbCommand(q, con);

            con.Open();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Success");
                 Admin Adminfrm = new Admin();
                Adminfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID, Please enter username and password");
            }

            reader.Close();
            con.Close();
        }
    }
}
