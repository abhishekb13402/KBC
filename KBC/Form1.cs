using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class Form1 : Form
    {
        string connetionString;
        SqlConnection cnn;
        int num,Correctcount=0;

        public void DataDisplay(int num)
        {

            string query = $"SELECT q_name, q_optA, q_optB, q_optC, q_optD, q_Correctopt FROM Questions where q_id={num}";

            SqlCommand command = new SqlCommand(query, cnn);

            SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lblquestion.Text = reader["q_name"].ToString();
                    rbbtna.Text = reader["q_optA"].ToString();
                    rbbtnb.Text = reader["q_optB"].ToString();
                    rbbtnc.Text = reader["q_optC"].ToString();
                    rbbtnd.Text = reader["q_optD"].ToString();
                    string q_correctopt = reader["q_Correctopt"].ToString();
                }

            reader.Close();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connetionString = @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=KBC;Integrated Security=True;";
            //connetionString = @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=KBC;Integrated Security=True;Trust Server Certificate=True";



            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");

            num = Randomnum();
            lblrandom.Text=num.ToString();
            DataDisplay(num);

        }

        private int Randomnum()
        {
            Random num = new Random();
            return num.Next(1, 6);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            num = Randomnum();
            lblrandom.Text = num.ToString();

            DataDisplay(num);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            
        }
    }
}
