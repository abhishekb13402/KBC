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
        SqlConnection cnn;
        string connetionString = @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=KBC;Integrated Security=True;";

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
                //LAPTOP-2AMVTRQA
                //MAYUR\SQLEXPRESS01
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM questions", connetionString);
                DataSet ds = new DataSet();
                da.Fill(ds, "questions");
                dataGridView1.DataSource = ds.Tables["questions"].DefaultView;

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
