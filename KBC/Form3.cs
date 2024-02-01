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

        SqlConnection cnn;
        int qid;
        string connetionString = @"Data Source=MAYUR\SQLEXPRESS01;Initial Catalog=KBC;Integrated Security=True;";

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
                dgview.DataSource = ds.Tables["questions"].DefaultView;

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

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            qid = Convert.ToInt32(dgview.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbq_name.Text=dgview.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbq_opta.Text= dgview.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbq_optb.Text= dgview.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbq_optc.Text= dgview.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbq_optd.Text= dgview.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbq_optd.Text= dgview.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
    }
}
