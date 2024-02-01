using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection cnn;
        public static int qcount;
        string connetionString= @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=KBC;Integrated Security=True;";



        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //logic for total questions available in database
            FetchTotalQuestioninDB();

        }

        private void FetchTotalQuestioninDB()
        {
            try
            {
                
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string query = string.Format("SELECT COUNT(q_id) FROM Questions");
                SqlCommand command = new SqlCommand(query, cnn);
                qcount = (int)command.ExecuteScalar();
                lbldislplaytotalquestion.Text= qcount.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error occure " + e);
            }
        }

        private void guestuserbtnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string username, userpassword;
                username = guestusername.Text;
                userpassword = guestuserpassword.Text;

                if (username == "admin" && userpassword == "admin")
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
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    string query = "select * from login where user_name = '" + guestusername.Text + "' and user_password = '" + guestuserpassword.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    txt2 = questionattendno.Text;

                    //1>0 && 6>3
                    if ((dataTable.Rows.Count > 0) && (qcount >= Convert.ToInt32(txt2)))
                    {
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
                }
                //else
                //{
                //    MessageBox.Show("Enter valid id password or question attempt number");
                //}
            }catch(Exception ex)
            {
                MessageBox.Show("error occure "+ex);
            }
        }

        
    }
}
