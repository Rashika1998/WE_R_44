using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_WE_R_44_TIME_TABLE
{
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {
            InitializeComponent();
        }

       


        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name, Reg, Class, Section FROM student_table", dataGridView);
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(this);
            formStudent.ShowDialog();
        }


        

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name, Reg, Class, Section FROM student_table WHERE Name Like'%"+txtSearch.Text+"%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Edit a row
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //Delete a row
                if (MessageBox.Show("Do you want to delete this student record..?", "Infromation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
