using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THWindowForm01
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private string edu, dept;

        private void Form3_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
        }

        private void lstEdu_SelectedIndexChanged(object sender, EventArgs e)
        {
            edu = lstEdu.Text;
        }

        private void cboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            dept = cboDep.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtJoin.Text = "";
            cboDep.Text = "";
            lstEdu.ClearSelected();
            btnClear.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Name is " + txtName);
            MessageBox.Show("Employee Address is " + txtAddress);
            MessageBox.Show("Joined on " + txtJoin.Text + "has education" + edu + "and belongs to dept " + dept);
            btnClear.Enabled = true;
        }
    }
}
