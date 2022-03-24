using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Covid
{
    public partial class PatientForm : Form
    {
        int ward = 1;
        int bed = 1;
        int docid = 1;
        int doclimit = 5;
        SqlDataReader oReader;
        SqlConnection connection;
        public PatientForm()
        {
            InitializeComponent();
            try
            {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arsalan\source\repos\Covid\Covid\Database1.mdf;Integrated Security=True");
                connection.Open();
                MessageBox.Show("Connected to Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void admittb_Click(object sender, EventArgs e)
        {
            string numberpattern = @"^\d{4}-\d{7}$";
            Match number = Regex.Match(mnumtb.Text, numberpattern);
            if (!number.Success)
                MessageBox.Show("Enter Number in (0300-1234567) format");
            string emailpattern = @"^[a-z0-9\._]+@[a-z]+.\w{3}$";
            Match email = Regex.Match(emailtb.Text, emailpattern);
            if (!email.Success)
                MessageBox.Show("Enter email in (abc@xyz.com) format");
            string pid = "PTR" + citytb.Text + DateTime.Now.ToString() + fnametb.Text;
            string gender = "";
            if (malerb.Checked)
                gender = "male";
            else if (femalerb.Checked)
                gender = "female";
            else
                gender = "X";
            while (true && docid <= 5)
            {
                SqlCommand sqlcmd = new SqlCommand("select count(*) from hospital where doctor_id ='" + docid + "'", connection);
                int count = (int)sqlcmd.ExecuteScalar();
                if (count == 5)
                    docid++;
                else
                    break;
            }
            if (docid > doclimit)
            {
                MessageBox.Show("Doctors Limit Reached");
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand("select count(*) from hospital", connection);
                int id = (int)sqlcmd.ExecuteScalar() + 1;
                string query = "insert into patient(MR_no, CNIC, pt_first_name, pt_last_name, father_or_husband, DOB, place_of_birth, blood_type, present_address, permanent_address, mobile_no, landline_no, email, city, gender, image, datetime, test, symptom) values('" + pid + "','" + cnictb.Text + "', '" + fnametb.Text + "', '" + lnametb.Text + "', '" + f_hnametb.Text + "', '" + dobpicker.Value.ToString() + "', '" + pobirthtb.Text + "','" + bloodgroupcb.Items[bloodgroupcb.SelectedIndex].ToString() + "', '" + presentaddtb.Text + "', '" + permaddresstb.Text + "', '" + mnumtb.Text + "', '" + pnumtb.Text + "', '" + emailtb.Text + "', '" + citytb.Text + "', '" + gender + "' ,'','" + DateTime.Now + "','" + testtb.Text + "','" + checkedListBox1.SelectedItems.ToString() + "')";
                string queryhospital = "insert into Hospital(id,Ward_no,Bed_no,doctor_id,MR_no) values('" + id + "','" + ward + "','" + bed + "','" + docid + "','" + pid + "')";
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    if (testtb.Text == "p" || testtb.Text == "positive" || testtb.Text == "Positive" || testtb.Text == "POSITIVE")
                    {
                        SqlCommand sqlCommand2 = new SqlCommand(queryhospital, connection);
                        sqlCommand2.ExecuteNonQuery();
                        MessageBox.Show("Patient admitted");
                        bed++;
                        if(bed>5)
                        {
                            bed = 1;
                            ward++;
                        }
                    }
                    else
                        MessageBox.Show("Patient Registered");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Invalidate();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string id = "";
            string query = "select * from patient where mobile_no='" + ptnumtb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            using (oReader = sqlCommand.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = oReader["MR_no"].ToString();
                    namelb.Text = oReader["pt_first_name"].ToString();
                    doblb.Text = oReader["DOB"].ToString();
                    timedatelb.Text = oReader["datetime"].ToString();
                }
            }
            string query1 = "select * from hospital where MR_no='" + id + "'";
            SqlCommand sqlCommand1 = new SqlCommand(query1, connection);
            using (SqlDataReader oReader1 = sqlCommand1.ExecuteReader())
            {
                while (oReader1.Read())
                {
                    bedwardlb.Text = oReader1["Bed_no"].ToString() + "/" + oReader1["Ward_no"].ToString();
                }
            }
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select count(*) from recovered_patient", connection);
            int id = (int)sqlCommand.ExecuteScalar();
            id++;
            if (recoveredrb.Checked)
            {
                using (oReader = sqlCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string query = "insert into recovered_patient(pd_no,date_of_discharge,pasme_donor_name,MR_number) values('" + id + "','" + DateTime.Now + "','" + oReader["pt_first_name"].ToString() + "','" + oReader["MR_no"].ToString() + "')";
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from recovered_patient", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet data = new DataSet();
            sqlDataAdapter.Fill(data);
            ptrecovereddsv.DataSource = data;
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
