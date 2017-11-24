using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop1_Click(object sender, EventArgs e)
        {
            lblMsg1.Text = " ";
            //use a loop to display #'s from 100-120 on labal
            //for (Int32 counter = 100; counter <= 120; counter + 2)
            //cuonter++ is the same as counter + 1 
            for (Int32 counter = 100; counter <= 120; counter+=2)
            {
                lblMsg1.Text += counter + ", ";
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lblMsg1.Text = " ";
            Int32 counter = 100;

            while (counter <= 120)
            {
                lblMsg1.Text += counter + " ";
                counter++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // capture x and y values
            Int32 x = Convert.ToInt32(txtX.Text);
            Int32 y = Convert.ToInt32(txtY.Text);

            // send x and y to the add number method
            Int32 result = AddNumbers(x, y);
            lblSum.Text = Convert.ToString(result);
            
        }

        private Int32 AddNumbers(Int32 x, Int32 y)
        {
            //add the 2 input parameter values together
            Int32 sum = x + y;
            //send result back out
            return sum;
        }
    }
}
