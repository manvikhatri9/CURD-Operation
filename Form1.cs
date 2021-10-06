using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Curd_operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-TB2TRJIJ;Initial Catalog=curd_operation;Integrated Security=True");

        public int Student_Id;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentData();
        }

        private void GetStudentData()
        {
            
          SqlConnection con = new SqlConnection("Data Source=LAPTOP-TB2TRJIJ;Initial Catalog=curd_operation;Integrated Security=True");
          SqlCommand cmd = new SqlCommand("Select * from StudentRecord",con);
          DataTable dt = new DataTable();

         con.Open();

         SqlDataReader sdr = cmd.ExecuteReader();
         dt.Load(sdr);
         con.Close();

         StudentRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into StudentRecord values(@name,@FatherName,@RollNumber,@Address,@MobileNumber)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text );

                con.Open();
                cmd.ExecuteNonQuery();    // used for executing queries that does not return any data. It is                                 used to execute the sql statements like update, insert, delete etc.                             ExecuteNonQuery executes the command and returns the number of rows                             affected
                con.Close();

                MessageBox.Show("New Student is successfully added in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentData();
                //Reset();
            }
        }

        private bool isValid()
        {
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Student Name Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Student_Id>0)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-TB2TRJIJ;Initial Catalog=curd_operation;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE StudentRecord SET Name = @Name,FatherName  = @FatherName,RollNumber = @RollNumber,Address = @Address,MobileNumber = @MobileNumber WHERE Student_Id = @Id",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text);
                cmd.Parameters.AddWithValue("@Id",this.Student_Id);

                con.Open();
                cmd.ExecuteNonQuery();                           
                con.Close();

                MessageBox.Show("Student information is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentData();
                //Reset();
            }
            else
            {
                MessageBox.Show("Please select a student to update his information", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtRollNumber.Clear();
            txtAddress.Clear();
            txtMobileNumber.Clear();

            txtName.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student_Id = Convert.ToInt32(StudentRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
