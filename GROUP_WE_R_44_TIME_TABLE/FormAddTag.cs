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

   
    public partial class FormAddTag : Form
    {

        //newly added 2021 04 05
        public string relatedTagBoxValue;

        public FormAddTag()
        {
            InitializeComponent();
            //newly added 2021 04 05
            relatedTagBox.Items.Add("Lecture");
            relatedTagBox.Items.Add("Tutorial");
            relatedTagBox.Items.Add("Lab");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void relatedTagBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            relatedTagBoxValue = relatedTagBox.SelectedItem.ToString();
            MessageBox.Show(relatedTagBoxValue);
        }
    }
}
