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

        //private void button1_Click(object sender, EventArgs e)
        //{
           

        //}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guestuserbtnsubmit_Click(object sender, EventArgs e)
        {
            if (guestusername.Text == "user" && guestuserpassword.Text == "user")
            {
                txt2 = questionattendno.Text;
                //hide form2
                this.Hide();
                //create time interval for the form1
                Form1 form1 = new Form1();
                form1.ShowDialog();//show form1
                                   //close form1 interval
                //form1 = null;
                //Now close form2 and come on form1
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter valid id password");
            }
        }

        private void adminbtnsubmit_Click(object sender, EventArgs e)
        {
            if (adminusername.Text == "admin" && adminuserpassword.Text == "admin")
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();//show form1
                                   //close form1 interval
                //form2 = null;
                //Now close form2 and come on form1
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter valid id password");
            }
        }
    }
}
