using Student_System.Controller;
using System;
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
    public partial class MainStudentSystem : Form
    {
        private StudentController studentController;

        public MainStudentSystem()
        {
            InitializeComponent();
            studentController = new StudentController();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            form.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGV.DataSource = null;
            dataGV.Refresh();
        }

       
        private void MainStudentSystem_Load(object sender, EventArgs e)
        {
            DataSet dataSet = studentController.getAllStudents();
            dataGV.DataSource = dataSet.Tables[0];
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGV_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            
        }

        private void MainStudentSystem_DoubleClick(object sender, EventArgs e)
        {
                   }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int StudentID = Convert.ToInt32(dataGV.SelectedRows[0].Cells[0].Value);
            UpdateStudent form = new UpdateStudent(StudentID);
            form.Show();
        }

        private void dataGV_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void updatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
