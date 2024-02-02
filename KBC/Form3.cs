using System;
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

        SqlConnection con;
        int qid;
        SqlCommand cmd;
        //SqlDataAdapter adapt;
        string connetionString = @"Data Source=MAYUR\SQLEXPRESS01;Initial Catalog=KBC;Integrated Security=True;";

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (qid != 0)
                {
                    con = new SqlConnection(connetionString);
                    cmd = new SqlCommand("Delete questions where q_id=@q_id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@q_id", qid);


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully click on display to view");
                    Display();
                    ClearData();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        public void Display(object sender, EventArgs e)
        {
            //button1_Click_1
            try

            {
                //LAPTOP-2AMVTRQA
                //MAYUR\SQLEXPRESS01
                con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM questions", connetionString);
                DataSet ds = new DataSet();
                da.Fill(ds, "questions");
                dgview.DataSource = ds.Tables["questions"].DefaultView; con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connetionString);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM questions", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "questions");
            dgview.DataSource = ds.Tables["questions"].DefaultView; con.Close();
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

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbq_name.Text != "" && tbq_opta.Text != "" && tbq_optb.Text != "" && tbq_optc.Text != "" && tbq_optd.Text != "" && tbq_Correctopt.Text != "")
                {
                    con = new SqlConnection(connetionString);
                    con.Open();
                    cmd = new SqlCommand("insert into questions(q_name,q_optA,q_optB,q_optC,q_optD,q_Correctopt) values(@q_name,@q_optA,@q_optB,@q_optC,@q_optD,@q_Correctopt)", con);

                    //cmd.Parameters.AddWithValue("@q_id", tbq_id.Text);
                    cmd.Parameters.AddWithValue("@q_name", tbq_name.Text);
                    cmd.Parameters.AddWithValue("@q_optA", tbq_opta.Text);
                    cmd.Parameters.AddWithValue("@q_optB", tbq_optb.Text);
                    cmd.Parameters.AddWithValue("@q_optC", tbq_optc.Text);
                    cmd.Parameters.AddWithValue("@q_optD", tbq_optd.Text);
                    cmd.Parameters.AddWithValue("@q_Correctopt", tbq_Correctopt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully click on display to view");

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please enter mandatory details!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("insert error " + ex);
            }
        }

        private void ClearData()
        {
            tbq_id.Text = "";
            tbq_name.Text = "";
            tbq_opta.Text = "";
            tbq_optb.Text = "";
            tbq_optc.Text = "";
            tbq_optd.Text = "";
            tbq_Correctopt.Text = "";

        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {

                if (tbq_name.Text != "" && tbq_opta.Text != "" && tbq_optb.Text != "" && tbq_optc.Text != "" && tbq_optd.Text != "" && tbq_Correctopt.Text != "")
                {
                    using (con = new SqlConnection(connetionString))
                    {
                        con.Open();
                        using (cmd = new SqlCommand("UPDATE questions SET q_name=@q_name, q_optA=@q_optA, q_optB=@q_optB, q_optC=@q_optC, q_optD=@q_optD, q_Correctopt=@q_Correctopt WHERE q_id=@q_id", con))
                        {
                            cmd.Parameters.AddWithValue("@q_id", tbq_id.Text);
                            cmd.Parameters.AddWithValue("@q_name", tbq_name.Text);
                            cmd.Parameters.AddWithValue("@q_optA", tbq_opta.Text);
                            cmd.Parameters.AddWithValue("@q_optB", tbq_optb.Text);
                            cmd.Parameters.AddWithValue("@q_optC", tbq_optc.Text);
                            cmd.Parameters.AddWithValue("@q_optD", tbq_optd.Text);
                            cmd.Parameters.AddWithValue("@q_Correctopt", tbq_Correctopt.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Updated Successfully. Click on Display to view.");
                                ClearData();
                            }
                            else
                            {
                                MessageBox.Show("No records updated. Check if the provided q_id exists.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter mandatory details!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("update error occure "+ex);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            qid = Convert.ToInt32(dgview.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbq_id.Text=dgview.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbq_name.Text=dgview.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbq_opta.Text= dgview.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbq_optb.Text= dgview.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbq_optc.Text= dgview.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbq_optd.Text= dgview.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbq_Correctopt.Text= dgview.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }
    }
}
