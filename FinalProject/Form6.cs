using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form6 : Form
    {

        private OleDbConnection conn;
        public Form6()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\FinalProject\Hotel.accdb");
            conn.Open();
        }
        private void loadData()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Info ORDER BY Name ASC", conn);
            DataTable Info = new DataTable();
            adapter.Fill(Info);
            DataGrid1.DataSource = Info;
            DataGrid1.ReadOnly = true;
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Info (Name, [Room_Type], [Number_of_Occupancy], [Contact_Number], [Check_in], [Check_out]) VALUES (@Name, @Room_Type, @Contact_Number, @Number_of_Occupancy, @Check_in, @Check_out)", conn);
            cmd.Parameters.AddWithValue("@Name", TxtName.Text);
            cmd.Parameters.AddWithValue("@Room_Type", CmbRoom1.SelectedItem);
            cmd.Parameters.AddWithValue("@Number_of_Occupancy", TxtNumber.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", TxtContact.Text);
            cmd.Parameters.AddWithValue("@Check_in", DatePicker1.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Check_out", DatePicker2.Value.ToShortDateString());
            cmd.ExecuteNonQuery();
            loadData();

            MessageBox.Show("Successfully Added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Info WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", TxtName.Text);
                cmd.ExecuteNonQuery();
                loadData();

                MessageBox.Show("Successfully Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtName.Clear();
                TxtNumber.Clear();
                // CmbRoom1.Clear();
                // TxtCheckOut.Clear();

            }
        }

        private void DataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGrid1.Rows[e.RowIndex];
                TxtName.Text = row.Cells["Name"].Value.ToString();
                CmbRoom1.SelectedItem = row.Cells["Room_Type"].Value.ToString();
                TxtNumber.Text = row.Cells["Number_of_Occupancy"].Value.ToString();
                TxtContact.Text = row.Cells["Contact_Number"].Value.ToString();
                DatePicker1.Value = Convert.ToDateTime(row.Cells["Check_in"].Value);
                DatePicker2.Value = Convert.ToDateTime(row.Cells["Check_out"].Value);

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            loadData();
            DataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TxtResult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
            TxtResult.Text += "*******************************************\n";
            TxtResult.Text += "**       Hotel Booking System            **\n";
            TxtResult.Text += "*******************************************\n";
            TxtResult.Text += "Date :" + DateTime.Now + "\n\n";
            TxtResult.Text += "Name: " + TxtName.Text + "\n\n";
            TxtResult.Text += "Room Type: " + CmbRoom1.SelectedItem + "\n\n";
            TxtResult.Text += "Number of Occupancy: " + TxtNumber.Text + "\n\n";
            TxtResult.Text += "Contact Number: " + TxtContact.Text + "\n\n";
            TxtResult.Text += "Check in: " + DatePicker1.Value.ToShortDateString() + " " + TxtTime1.Text + "\n\n";
            TxtResult.Text += "Check out: " + DatePicker2.Value.ToShortDateString() + " " + TxtTime2.Text + "\n\n";
            // DateTime currentTime = DateTime.Now.TimeOfDay;
            // TxtResult.Text += "Current Time: " + currentTime.ToString() + "\n";

        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void CmbRoom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string selected = CmbRoom1.SelectedItem.ToString();

                if (selected == "Deluxe")
                {
                    LblPrice.Text = "750.00";
                }
                else if (selected == "Premium")
                {
                    LblPrice.Text = "1000.00";
                }
                else if (selected == "Executive")
                {
                    LblPrice.Text = "1650.00";
                }

            }
        }
        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            TxtName.Clear();
            TxtNumber.Clear();
            CmbRoom1.Text = string.Empty;
            TxtNumber.Clear();
            TxtTime1.Clear();
            TxtTime2.Clear();
            LblPrice.Text = "00";

        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will Contact you as soon as possible, Thank You for Booking Have a nice day ahead!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Info WHERE Name LIKE '%" + TxtSearch.Text + "%'  ORDER BY Name ASC", conn);
            DataTable Info = new DataTable();
            adapter.Fill(Info);
            DataGrid1.DataSource = Info;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE Info SET Name = @Name, Room_Type = @Room_Type, Contact_Number = @Contact_Number, Number_of_Occupancy = @Number_of_Occupancy, Check_in = @Check_in WHERE Check_out = @Check_out", conn);
                cmd.Parameters.AddWithValue("@Name", TxtName.Text);
                cmd.Parameters.AddWithValue("@Room_Type", CmbRoom1.Text);
                cmd.Parameters.AddWithValue("@Contact_Number", TxtContact.Text);
                cmd.Parameters.AddWithValue("@Number_of_Occupancy", TxtNumber.Text);
               // cmd.Parameters.AddWithValue("@Chec_in", D.Text);
                cmd.ExecuteNonQuery();
                loadData();

                MessageBox.Show("Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
