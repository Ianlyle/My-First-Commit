using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FrmResort : Form
    {
        public FrmResort()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void BtnCheck1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
            Form6 f7 = new Form6();
            f7.Show();
            this.Hide();
        }

        private void BtnCheck3_Click(object sender, EventArgs e)
        {
            Form6 f8 = new Form6();
            f8.Show();
            this.Hide();
        }
    }
}
