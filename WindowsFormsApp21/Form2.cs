using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "111")
            {
                Form1 x = new Form1();
                x.Show();
                this.Hide();
            }
            else if (textBox1.Text == "2" && textBox2.Text == "222")
            {
                Form3 x = new Form3();
                x.Show();
                this.Hide();
            }
            else
                MessageBox.Show("حاول مرة اخرى");
        }
    }
}
