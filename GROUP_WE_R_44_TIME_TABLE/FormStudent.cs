﻿using System;
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
    public partial class FormStudent : Form
    {

        private readonly FormStudentInfo _parent;


        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
            
        }


        public void Clear()
        {
            txtName.Text = txtReg.Text = txtClass.Text = txtSection.Text = string.Empty;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is empty ( > 3).");
                return;
            }
            if (txtReg.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student reg no is empty ( > 1).");
                return;
            }
            if (txtClass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student class is empty ( > 0).");
                return;
            }
            if (txtSection.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student section is empty ( > 0).");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }

            _parent.Display();
        }

        //Student update function need to be implemented
        private void FormStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
