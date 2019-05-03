using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class frmCalcultorApp : Form
    {
        public frmCalcultorApp()
        {
            InitializeComponent();
        }

        private void frmCalcultorApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();
            if (val1 > 0 && val2 > 0)
            { 

            lblResult.ForeColor = Color.Black;
            lblResult.Text = "Result = " + (val1 + val2).ToString();

            }
            lblResult.Visible = true;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Black;
                lblResult.Text = "Result = " + (val1 * val2).ToString();
            }

            lblResult.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstValue.Text = "";
            txtSecondValue.Text = "";
            lblResult.Text = "";
            txtFirstValue.Focus();
        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public double GetFirstValue()
        {
            double val1;

            while(!double.TryParse(txtFirstValue.Text, out val1))
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "must be numeric greater than 0";
                txtFirstValue.Text = "0";

            }
            return val1;
        }

        public double GetSecondValue()
        {
            double val2;

            while(!double.TryParse(txtSecondValue.Text, out val2))
            {
                
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "must be numeric greater than 0";
                txtSecondValue.Text = "0";

            }
            return val2;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {

                lblResult.ForeColor = Color.Black;
                lblResult.Text = "Result = " + (val1 - val2).ToString();
            }

            lblResult.Visible = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Black;
                lblResult.Text = "Result = " + (val1 / val2).ToString();
            }

            lblResult.Visible = true;
        }
    }
}
