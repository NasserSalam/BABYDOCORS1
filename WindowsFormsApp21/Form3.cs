using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp21
{
    public partial class Form3 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter Adapter;
        DataTable dt;
        void GetInfo2()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baby.accdb");
            dt = new DataTable();
            Adapter = new OleDbDataAdapter("Select * From BabyInfo", conn);
            conn.Open();
            Adapter.Fill(dt);
            datainfo.DataSource = dt;
            conn.Close();

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void datainfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 xform = new Form2();
            xform.Show();
            this.Hide();
        }
        private void datainfo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TID.Text = datainfo.CurrentRow.Cells[0].Value.ToString();
            TName.Text = datainfo.CurrentRow.Cells[1].Value.ToString();
            TAge.Text = datainfo.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = datainfo.CurrentRow.Cells[10].Value.ToString();
            textBox3.Text = datainfo.CurrentRow.Cells[11].Value.ToString();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
              dv.RowFilter = "Patient_Name LIKE '%" + textBox2.Text + "%'";
            datainfo.DataSource = dv;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetInfo2();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM BabyInfo WHERE ID=@id ";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", Convert.ToInt16(TID.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Done Delete ..");
            GetInfo2();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string query = "UPDATE BabyInfo SET Patient_Name=@name,Age=@age,Disease_Diagnosis=@dd,treatment=@t WHERE ID=@id ";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", TName.Text);
            cmd.Parameters.AddWithValue("@age", TAge.Text);
            cmd.Parameters.AddWithValue("@dd", textBox1.Text);
            cmd.Parameters.AddWithValue("@t", textBox3.Text);

            cmd.Parameters.AddWithValue("@id", Convert.ToInt16(TID.Text));



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Done Update ..");
            GetInfo2();
        }

        private void datainfo_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            TID.Text = datainfo.CurrentRow.Cells[0].Value.ToString();
            TName.Text = datainfo.CurrentRow.Cells[1].Value.ToString();
            TAge.Text = datainfo.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = datainfo.CurrentRow.Cells[10].Value.ToString();
            textBox3.Text = datainfo.CurrentRow.Cells[11].Value.ToString();

        }
    }
}
