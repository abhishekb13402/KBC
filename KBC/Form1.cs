using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class Form1 : Form
    {
  
        string connetionString, q_correctopt;
        SqlConnection cnn;
        int num, Correctcount = 0,totalNoOfQuestions=0;
        int currentQuestionCount = 1;
        string currentSelectedAnswerText = string.Empty;
        public void DataDisplay(int num)
        {
            try
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
                        q_correctopt = reader["q_Correctopt"].ToString();
                    }

                    reader.Close();
                
                
                
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database connection error" + sqlEx.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured." + ex.ToString());
            }
        }

        
        public Form1()
        {
            
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            {
                QNumber.Text = Form2.txt2;
                totalNoOfQuestions = Convert.ToInt32(QNumber.Text);
            connetionString = @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=KBC;Integrated Security=True;";
            //connetionString = @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=KBC;Integrated Security=True;Trust Server Certificate=True";




            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Connection Open  !");

            Resetcomponent();
            num = Randomnum();
            lblrandom.Text = num.ToString();
            DataDisplay(num);
        }
             catch (SqlException sqlEx)
            {
                MessageBox.Show("Database connection error" + sqlEx.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured." + ex.ToString());
            }

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

        private void rbbtna_CheckedChanged(object sender, EventArgs e)
        {
            currentSelectedAnswerText = (rbbtna.Checked) ? rbbtna.Text : "";

           // rbbtna.BackColor =  (rbbtna.Checked && rbbtna.Text == q_correctopt) ? Color.Green : Color.Red;
        }

        private void rbbtnb_CheckedChanged(object sender, EventArgs e)
        {
            currentSelectedAnswerText = (rbbtnb.Checked) ? rbbtnb.Text : "";
            //rbbtnb.BackColor=(rbbtnb.Checked &&rbbtnb.Text==q_correctopt) ? Color.Green :Color.Red;
        }

        private void rbbtnc_CheckedChanged(object sender, EventArgs e)
        {
            currentSelectedAnswerText = (rbbtnc.Checked) ? rbbtnc.Text : "";

            //rbbtnc.BackColor = (rbbtnc.Checked && rbbtnc.Text == q_correctopt) ? Color.Green : Color.Red;
        }

        private void rbbtnd_CheckedChanged(object sender, EventArgs e)
        {
            currentSelectedAnswerText = (rbbtnd.Checked) ? rbbtnd.Text : "";

            //rbbtnd.BackColor = (rbbtnd.Checked && rbbtnd.Text == q_correctopt) ? Color.Green : Color.Red;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateAnserSelected())
                {
                    MessageBox.Show("Please select answer first.");
                    return;
                }

                displayNextQuestion();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Some error occured." + ex.ToString());
            }
        }

        private void displayNextQuestion()
        {
            if (currentQuestionCount < totalNoOfQuestions)
            {
                btnsave.Enabled = true;
                num = Randomnum();
                lblrandom.Text = num.ToString();

                Resetcomponent();
                DataDisplay(num);
                currentQuestionCount = currentQuestionCount + 1;
            }
            else
            {
                MessageBox.Show("Question completed Score is: "+Correctcount);
                //OpenFileDialog form 2
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

        private bool validateAnserSelected()
        {
            return !rbbtna.Checked && !rbbtnb.Checked && !rbbtnc.Checked && !rbbtnd.Checked;
        }

        private void Resetcomponent()
        {
            rbbtna.BackColor = Color.White;
            rbbtnb.BackColor = Color.White;
            rbbtnc.BackColor = Color.White;
            rbbtnd.BackColor = Color.White;

            rbbtna.Checked = false; 
            rbbtnb.Checked = false;
            rbbtnc.Checked = false; 
            rbbtnd.Checked = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Array to hold the radio buttons
                RadioButton[] radioButtons = { rbbtna, rbbtnb, rbbtnc, rbbtnd };

                // Iterate over each radio button
                foreach (RadioButton radioButton in radioButtons)
                {
                    // Check if the current radio button is checked and its text matches the correct option
                    if (radioButton.Checked && radioButton.Text == q_correctopt)
                    {
                        radioButton.BackColor = Color.Green; // Set background color to green
                        Correctcount++; // Increment the correct count
                    }
                    else
                    {
                        radioButton.BackColor = Color.Red; // Set background color to red
                    }
                }

                //MessageBox.Show($"Correct Answers: {q_correctopt}, Score: {Correctcount}");
                btnsave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occurred: " + ex.ToString());
            }
        }

    }
}
