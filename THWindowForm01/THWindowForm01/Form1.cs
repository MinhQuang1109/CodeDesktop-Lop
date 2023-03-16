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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.txtUser.Text.Equals("Admin"))
            {
                if (this.txtPass.Text.Equals("Admin"))
                {
                    FrmEmployee objEmp = new FrmEmployee();
                    objEmp.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Password is invalid");
            }
            MessageBox.Show("User is invalid");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
