using Student_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System.Controller
{
    class StudentController
    {
        private DBConnection dbConnection;
        
        public StudentController()
        {
            dbConnection = new DBConnection();
        }

        public DataSet getAllStudents()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = dbConnection.OpenConnection();
                command.CommandText = "GetAllStudents";
                command.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to fetch Students records", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                command.Connection.Close();
            }
            return dataSet;
        }

        public bool addStudent(Student student)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "AddStudent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 25).Value = student.Name;
                cmd.Parameters.Add("@FatherName", SqlDbType.VarChar, 25).Value = student.FatherName;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = student.Gender;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 35).Value = student.Email;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = student.DOB;
                cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = student.CityID;
                cmd.Parameters.Add("@LocalityID", SqlDbType.Int).Value = student.LocalityID;
                cmd.Parameters.Add("@PostCode", SqlDbType.NChar).Value = student.PostCode;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = student.Address;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar).Value = student.Comment;
                cmd.Parameters.Add("@FundType", SqlDbType.VarChar).Value = student.FundType;
                cmd.Parameters.Add("@FeeType", SqlDbType.VarChar).Value = student.FeeType;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Add Student");
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public bool editStudent(Student student)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "EditStudent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = student.StudentID;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 25).Value = student.Name;
                cmd.Parameters.Add("@FatherName", SqlDbType.VarChar, 25).Value = student.FatherName;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = student.Gender;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 35).Value = student.Email;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = student.DOB;
                cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = student.CityID;
                cmd.Parameters.Add("@LocalityID", SqlDbType.Int).Value = student.LocalityID;
                cmd.Parameters.Add("@PostCode", SqlDbType.NChar).Value = student.PostCode;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = student.Address;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar).Value = student.Comment;
                cmd.Parameters.Add("@FundType", SqlDbType.VarChar).Value = student.FundType;
                cmd.Parameters.Add("@FeeType", SqlDbType.VarChar).Value = student.FeeType;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Update Student");
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }


        public Student getStudentByID(Student student)
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection.OpenConnection();
                cmd.CommandText = "GetStudentByID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = student.StudentID;

                reader = cmd.ExecuteReader();
                reader.Read();
                student.Name = reader["Name"].ToString();
                student.FatherName = reader["FatherName"].ToString();
                student.Email = reader["Email"].ToString();
                student.DOB = reader["DOB"].ToString();
                student.Gender = Convert.ToBoolean(reader["Gender"].ToString());
                student.CityID = Convert.ToInt32(reader["CityID"]);
                student.LocalityID = Convert.ToInt32(reader["LocalityID"]);
                student.PostCode = reader["PostCode"].ToString();
                student.Address = reader["Address"].ToString();
                student.Comment = reader["Comment"].ToString();
                student.FundType = Convert.ToInt32(reader["FundType"]);
                student.FeeType = Convert.ToInt32(reader["FeeType"]);

                return student;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to fetch Students records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return student;
            }
            finally
            {
                cmd.Connection.Close();
            }

        }
    }
}
