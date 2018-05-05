using Student_System.Controller;
using Student_System.Model;
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

namespace Student_System
{
    public partial class UpdateStudent : Form
    {
        private Student student;
        private StudentController studentController;
        private DBConnection dbConnection;

        public UpdateStudent(int StudentID)
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            student = new Student();
            student.StudentID = StudentID;
            studentController = new StudentController();
            
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            getStudent();
            
        }

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getStudent()
        {
            student = studentController.getStudentByID(student);

            txtName.Text = student.Name;
            txtFatherName.Text = student.FatherName;
            txtEmail.Text = student.Email;
            dateTimePickerDOB.Value = Convert.ToDateTime(student.DOB);
            bool gender = Convert.ToBoolean(student.Gender);
            if (gender == true)
            {
                radioBtnMale.Checked = true;
            }
            else
            {
                radioBtnFemale.Checked = true;
            }

            txtPostCode.Text = student.PostCode;
            txtAddress.Text = student.Address;
            richTxtComment.Text = student.Comment;

            DataSet dataSet = getCities();
            cmbCity.DataSource = dataSet.Tables[0];
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityID";
            cmbCity.SelectedValue = student.CityID;

            dataSet = getFundType();
            cmbFundType.DataSource = dataSet.Tables[0];
            cmbFundType.DisplayMember = "ListItem";
            cmbFundType.ValueMember = "ListID";
            cmbFundType.SelectedValue = student.FundType;

            dataSet = getFeeType();
            cmbFeeType.DataSource = dataSet.Tables[0];
            cmbFeeType.DisplayMember = "ListItem";
            cmbFeeType.ValueMember = "ListID";
            cmbFeeType.SelectedValue = student.FeeType;

            dataSet = getLocalitiesByCityID(student.CityID);
            cmbLocality.DataSource = dataSet.Tables[0];
            cmbLocality.DisplayMember = "Description";
            cmbLocality.ValueMember = "LocalityID";
            cmbLocality.SelectedValue = student.LocalityID;

        }

        private DataSet getCities()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "GetCities";
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on fetching Cities");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return dataSet;
        }

        private DataSet getLocalitiesByCityID(int cityID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "GetLocalitiesByCityID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = cityID;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on fetching Localities");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return dataSet;
        }

        private DataSet getFundType()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "GetFundType";
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on fetching Fund Type");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return dataSet;
        }

        private DataSet getFeeType()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "GetFeeType";
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on fetching Fee Type");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return dataSet;
        }

        private void cmbCity_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex != -1 && cmbCity.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int cityID = Convert.ToInt32(cmbCity.SelectedValue);

                DataSet dataSet = getLocalitiesByCityID(cityID);
                cmbLocality.DataSource = dataSet.Tables[0];
                cmbLocality.DisplayMember = "Description";
                cmbLocality.ValueMember = "LocalityID";
                cmbLocality.SelectedIndex = -1;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            student.Name = txtName.Text;
            student.FatherName = txtFatherName.Text;
            student.Email = txtEmail.Text;
            student.DOB = dateTimePickerDOB.Value.ToString();
            student.CityID = cmbCity.SelectedIndex + 1;
            student.LocalityID = cmbLocality.SelectedIndex + 1;
            student.PostCode = txtPostCode.Text;
            student.Comment = richTxtComment.Text;
            student.Address = txtAddress.Text;
            student.FundType = cmbFundType.SelectedIndex + 1;
            student.FeeType = cmbFeeType.SelectedIndex + 1;
            student.Gender = true;
            if (radioBtnMale.Checked == true)
            {
                student.Gender = true;
            }
            if (radioBtnFemale.Checked == true)
            {
                student.Gender = false;
            }

            int interestJava = 0;
            int interestPython = 0;
            int interestCSharp = 0;

            if (checkBoxCSharp.Checked == true)
            {
                interestCSharp = 1;
            }
            if (checkBoxPython.Checked == true)
            {
                interestPython = 1;
            }
            if (checkBoxJava.Checked == true)
            {
                interestJava = 1;
            }

            student.FundType = Convert.ToInt32(cmbFundType.SelectedValue);
            student.FeeType = Convert.ToInt32(cmbFeeType.SelectedValue);
            student.CityID = Convert.ToInt32(cmbCity.SelectedValue);
            student.LocalityID = Convert.ToInt32(cmbLocality.SelectedValue);

            if (studentController.editStudent(student))
            {
                MessageBox.Show("Student successfully updated.", "Student Updated");
                getStudent();
            }
        }
    }
}

