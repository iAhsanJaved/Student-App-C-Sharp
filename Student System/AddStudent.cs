using Student_System.Controller;
using Student_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System
{
    public partial class AddStudent : Form
    {
        private DBConnection dbConnection;
        private Student student;
        private StudentController studentController;
        public AddStudent()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            student = new Student();
            studentController = new StudentController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            if (studentController.addStudent(student))
            {
                MessageBox.Show("Student successfully added.", "Student Added");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            DataSet dataSet = getCities();
            cmbCity.DataSource = dataSet.Tables[0];
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityID";
            cmbCity.SelectedIndex = -1;

            dataSet = getFundType();
            cmbFundType.DataSource = dataSet.Tables[0];
            cmbFundType.DisplayMember = "ListItem";
            cmbFundType.ValueMember = "ListID";
            cmbFundType.SelectedIndex = -1;

            dataSet = getFeeType();
            cmbFeeType.DataSource = dataSet.Tables[0];
            cmbFeeType.DisplayMember = "ListItem";
            cmbFeeType.ValueMember = "ListID";
            cmbFeeType.SelectedIndex = -1;
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

        private void cmbCity_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
