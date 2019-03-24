using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double value1 = 0;
        private double value2 = 0;
        private String operationValue = "";
        private bool operationClicked = false;
        private bool point = false;
        private bool equals = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void But_number_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (txt_result.Text == "0" || operationClicked)
            {
                //txt_result.Clear();
                txt_result.Text = "";
            }

            operationClicked = false;
            txt_result.Text += b.Text;
            if (operationValue != "") equals = true;

        }

        private void But_point_Click(object sender, EventArgs e)
        {
            Button me = sender as Button;
            if(!point)
            {
                txt_result.Text += me.Text;
                point = true;
            }
        }


        private void But_operation_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(operationValue == "")
            {
                value1 = Double.Parse(txt_result.Text);
                operationValue = b.Text;
                lbl_info.Text = value1 + " " + operationValue;
                operationClicked = true;
            }

        }


        private void But_equals_Click(object sender, EventArgs e)
        {
            Button me = sender as Button;
            Double res = 0;
            //MessageBox.Show(equals.ToString());
            if (equals)
            {
                value2 = Double.Parse(txt_result.Text);
                
                if (operationValue == but_plus.Text)
                {
                    res = value1 + value2;
                }
                else if (operationValue == but_minus.Text)
                {
                    res = value1 - value2;
                }
                else if (operationValue == but_multi.Text)
                {
                    res = value1 * value2; ;
                }
                else if (operationValue == but_divide.Text)
                {
                    res = value1 / value2;
                }
                txt_result.Text = res.ToString();
                value1 = res;
                value2 = 0;
                equals = false;
                operationClicked = false;
                operationValue = "";
                lbl_info.Text = "";
            }
        }





        private void But_sign_Click(object sender,EventArgs e)
        {

            if(txt_result.Text.Substring(0, 1) != "-")
            {
                txt_result.Text = txt_result.Text.Insert(0, "-");
            }else if(txt_result.Text.Substring(0, 1) == "-")
            {
                txt_result.Text = txt_result.Text.Substring(1);
            }

        }


        private void But_ce_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
            value1 = 0;
            value2 = 0;

            point = false;
            operationClicked = false;
            operationValue = "";
            equals = false;
            lbl_info.Text = "";

        }

        private void But_c_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }


        private void But_check_Click(object sender, EventArgs e)
        {
            var n = "1,01";
            double n2 = .5;
            double r = Double.Parse(n) - n2;

            n = n.Insert(0, "-");
            //MessageBox.Show(r.ToString());
        }
    }
}
