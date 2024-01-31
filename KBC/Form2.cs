using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class Form2 : Form
    {
        public static string txt2 = "";
        
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt2= textBox1.Text;
            //hide form2
            this.Hide();
            //create time interval for the form1
            Form1 form1 = new Form1();
            form1.ShowDialog();//show form1
            //close form1 interval
            form1 = null;
            //Now close form2 and come on form1
            this.Close();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
