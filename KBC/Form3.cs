﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void Display(object sender, EventArgs e)
        {
            //button1_Click_1
            try

            {
                 String str = @"Data Source=MAYUR\SQLEXPRESS01;Initial Catalog=KBC;Integrated Security=True;";

                String query = "select * from questions";

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                DataSet ds = new DataSet();

                MessageBox.Show("connect with sql server");

                //con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            //create time interval for the form1
            Form2 form2 = new Form2();
            form2.ShowDialog();//show form1
                               //close form1 interval
                               //form1 = null;
                               //Now close form2 and come on form1
            this.Close();
        }
    }
}
