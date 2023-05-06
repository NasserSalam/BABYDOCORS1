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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter Adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        void GetInfo()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baby.accdb"  ); 
            dt = new DataTable();
            Adapter = new OleDbDataAdapter("Select * From BabyInfo", conn);
            conn.Open();
            Adapter.Fill(dt);
            datainfo.DataSource = dt;
            conn.Close();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // اضافة عنصر جديد
            // اضافة عنصر جديد
            string query = "INSERT INTO BabyInfo (Patient_Name,Age,height,weight,blood_type,Num_Phone,allergy,Pre_booking,Booking_Number,Disease_Diagnosis) VALUES" +
          "(@name,@age,@he,@we,@blood,@phone,@all,@pre,@book,@dd)";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", TName.Text);
            cmd.Parameters.AddWithValue("@age", TAge.Text);
            cmd.Parameters.AddWithValue("@he", THi.Text);
            cmd.Parameters.AddWithValue("@we", TWi.Text);
            cmd.Parameters.AddWithValue("@blood", TBlood.Text);
            cmd.Parameters.AddWithValue("@phone", TPho.Text);
            cmd.Parameters.AddWithValue("@all", TAL.Text);
            cmd.Parameters.AddWithValue("@pre", TPre.Value);
            cmd.Parameters.AddWithValue("@book", TBook.Text);
            cmd.Parameters.AddWithValue("@dd", "?");

            TAge.Text = "";


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Done Insert ..");
            GetInfo();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // تعديل عنصر 
            

            string query = "UPDATE BabyInfo SET Patient_Name=@name,Age=@age,height=@he,weight=@we,blood_type=@blood," +
                "Num_Phone=@phone,allergy=@all,Pre_booking=@pre,Booking_Number=@book WHERE ID=@id ";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", TName.Text);
            cmd.Parameters.AddWithValue("@age", TAge.Text);
            cmd.Parameters.AddWithValue("@he", THi.Text);
            cmd.Parameters.AddWithValue("@we", TWi.Text);
            cmd.Parameters.AddWithValue("@blood", TBlood.Text);
            cmd.Parameters.AddWithValue("@phone", TPho.Text);
            cmd.Parameters.AddWithValue("@all", TAL.Text);
            cmd.Parameters.AddWithValue("@pre", TPre.Value);
            cmd.Parameters.AddWithValue("@book", TBook.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt16(TID.Text));

            

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Done Update ..");
            GetInfo();
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
            GetInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // datainfo.Hide();
            GetInfo();
        }

        private void datainfo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TID.Text = datainfo.CurrentRow.Cells[0].Value.ToString();
            TName.Text = datainfo.CurrentRow.Cells[1].Value.ToString();
            TAge.Text = datainfo.CurrentRow.Cells[2].Value.ToString();
            THi.Text = datainfo.CurrentRow.Cells[3].Value.ToString();
            TWi.Text = datainfo.CurrentRow.Cells[4].Value.ToString();
            TBlood.Text = datainfo.CurrentRow.Cells[5].Value.ToString();
            TPho.Text = datainfo.CurrentRow.Cells[6].Value.ToString();
            TAL.Text = datainfo.CurrentRow.Cells[7].Value.ToString();
            TBook.Text = datainfo.CurrentRow.Cells[8].Value.ToString();
            TPre.Text = datainfo.CurrentRow.Cells[9].Value.ToString();

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 xform = new Form2();
            xform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void datainfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
