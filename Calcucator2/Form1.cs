using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcucator2
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public bool dot;
        public bool isGood;
        public string goodElement;
        public Form1()
        {
            n2 = false;
            dot = false;
            isGood = false;
            InitializeComponent();
            KeyPreview = true;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                maskedTextBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (maskedTextBox1.Text == "0")
                maskedTextBox1.Text = B.Text;
            else
                maskedTextBox1.Text = maskedTextBox1.Text + B.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = maskedTextBox1.Text;
            n2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(maskedTextBox1.Text);

            if (D == "/") res = dn1 / dn2;
            if (D == "x") res = dn1 * dn2;
            if (D == "+") res = dn1 + dn2;
            if (D == "-") res = dn1 - dn2;
            if (D == "%") res = (dn1 * dn2) / 100;

            D = "=";
            n2 = true;
            maskedTextBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double res = 0, dn;
            dn = Convert.ToDouble(maskedTextBox1.Text);
            Button B = (Button)sender;
            D = B.Text;

            if (D == "√") res = Math.Sqrt(dn);
            if (D == " x²")
            {
                res = Math.Pow(dn, 2);
            } 
            if (D == "1/x") res = 1 / dn;

            

            maskedTextBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string nums = maskedTextBox1.Text;
            if (maskedTextBox1.Text == "")
            {
                return;
            }

            if (nums.Length == 1)
            {
                maskedTextBox1.Text = "0";
                return;
            }
            else
            {
                nums = nums.Substring(0, nums.Length - 1);
                maskedTextBox1.Text = nums;
                return;
            }


          //  maskedTextBox1.Text = nums;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (dot)
            {
                maskedTextBox1.Text = maskedTextBox1.Text;
            }
            else
            { 
                maskedTextBox1.Text = maskedTextBox1.Text + ",";
                dot = true;
            }
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn = Convert.ToDouble(maskedTextBox1.Text);
            dn *= -1;
            maskedTextBox1.Text = dn.ToString();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
      
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] syms = { '+', '-', '*', '/', '%' };
            string[] empty = { "\0" };
            
            for (int i = 0; i < syms.Length; i++)
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == syms[i]) || e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
           
            e.KeyChar = Convert.ToChar(empty[0]);
                       
                
            
   
            
        }
    }
}
