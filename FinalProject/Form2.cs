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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void BtnHotel_Click(object sender, EventArgs e)
        {
            FrmHotels f2= new FrmHotels();
            f2.Show();
            this.Hide();
        }

        private void BtnResort_Click(object sender, EventArgs e)
        {
            FrmResort f3= new FrmResort();
            f3.Show();
            this.Hide();
        }
    }
}
