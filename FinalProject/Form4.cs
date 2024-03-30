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
    public partial class FrmHotels : Form
    {
        public FrmHotels()
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
            Form6 f3= new Form6();
            f3.Show();
            this.Hide();
        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
            Form7 f4 = new Form7();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f5 = new Form8();
            f5.Show();
            this.Hide();
        }

        private void FrmHotels_Load(object sender, EventArgs e)
        {

        }
    }
}
